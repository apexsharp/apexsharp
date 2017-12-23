using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Threading;
using Type = System.Type;

namespace Apex.ApexSharp.Implementation
{
	public class Implementor
	{
        public static ConcurrentDictionary<Type, Type> DefaultImplementations { get; } =
            DiscoverDefaultImplementations();

        private static ConcurrentDictionary<Type, Type> DiscoverDefaultImplementations()
        {
            var result = new ConcurrentDictionary<Type, Type>();
            var implementationTypes =
                from t in typeof(Implementor).Assembly.GetTypes()
                where t.IsDefined(typeof(ImplementsAttribute), false)
                select t;

            foreach (var implementationType in implementationTypes)
            {
                var implements = implementationType.GetCustomAttribute<ImplementsAttribute>();
                var apiType = implements.Type;
                result[apiType] = implementationType;
            }

            return result;
        }

        public static ConcurrentDictionary<Type, dynamic> ImplementationRepository { get; private set; } =
            new ConcurrentDictionary<Type, dynamic>();

        public static dynamic GetDefaultImplementation<T>() => GetDefaultImplementation(typeof(T));

        public static dynamic GetDefaultImplementation(Type type)
        {
            // if there is the default implementation — create it
            if (DefaultImplementations.TryGetValue(type, out var implType))
            {
                return Activator.CreateInstance(implType);
            }

            // if the type is generic — try to deconstruct it
            if (type.IsGenericType)
            {
                var typeDef = type.GetGenericTypeDefinition();
                if (DefaultImplementations.TryGetValue(typeDef, out var getImplType))
                {
                    // and reconstruct the implementation type with the same parameters
                    implType = getImplType.MakeGenericType(type.GetGenericArguments());
                    return Activator.CreateInstance(implType);
                }
            }

            // no default implementation — create the stub
            return new StubImplementation(type);
        }

        public static dynamic GetImplementation<T>() => GetImplementation(typeof(T));

        public static dynamic GetImplementation(Type type)
        {
            if (ImplementationRepository.TryGetValue(type, out var result))
            {
                return result;
            }

            var impl = GetDefaultImplementation(type);
            ImplementationRepository[type] = impl;
            return impl;
        }

        public static void SetImplementation<T>(dynamic impl) => SetImplementation(typeof(T), impl);

        public static void SetImplementation(Type type, dynamic impl)
        {
            ImplementationRepository[type] = impl;
        }

        public static void ResetToDefault<T>() => ResetToDefault(typeof(T));

        public static void ResetToDefault(Type type)
        {
            ImplementationRepository.TryRemove(type, out var _);
        }

        public static void ResetToDefault()
        {
            ImplementationRepository.Clear();
        }

        public static IDisposable UseDefaultImplementations()
        {
            var oldRepository = ImplementationRepository;
            ImplementationRepository = new ConcurrentDictionary<Type, dynamic>();

            return new Disposable(() =>
            {
                ImplementationRepository = oldRepository;
            });
        }

        public static IDisposable UseDefaultImplementation<T>() => UseDefaultImplementation(typeof(T));

        public static IDisposable UseDefaultImplementation(Type type)
        {
            var oldExisted = ImplementationRepository.TryRemove(type, out dynamic old);

            return new Disposable(() =>
            {
                if (oldExisted)
                {
                    ImplementationRepository[type] = old;
                }
                else
                {
                    ImplementationRepository.TryRemove(type, out var tmp);
                }
            });
        }

        public static IDisposable UseStubImplementation<T>() => UseStubImplementation(typeof(T));

        public static IDisposable UseStubImplementation(Type type)
        {
            var result = UseDefaultImplementation(type);
            ImplementationRepository[type] = new StubImplementation(type);
            return result;
        }

        public static T GetDefault<T>() => (T)GetDefault(typeof(T));

        public static object GetDefault(Type type)
        {
            if (type.IsValueType)
            {
                return Activator.CreateInstance(type);
            }

            return null;
        }
    }
}