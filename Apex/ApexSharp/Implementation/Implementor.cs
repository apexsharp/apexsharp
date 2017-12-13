using System;
using System.Collections.Concurrent;
using System.Threading;
using Type = System.Type;

namespace Apex.ApexSharp.Implementation
{
	public class Implementor
	{
        //public static ConcurrentDictionary<Type, dynamic> ImplementationRepository { get; private set; } =
        //    new ConcurrentDictionary<Type, dynamic>();

        //public static dynamic GetDefaultImplementation(Type type) =>
        //    new StubImplementation(type.FullName);

        //public static dynamic GetImplementation<T>() => GetImplementation(typeof(T));

        //public static dynamic GetImplementation(Type type)
        //{
        //    if (ImplementationRepository.TryGetValue(type, out var result))
        //    {
        //        return result;
        //    }

        //    var impl = GetDefaultImplementation(type);
        //    ImplementationRepository[type] = impl;
        //    return impl;
        //}

        //public static void SetImplementation<T>(dynamic impl) => SetImplementation(typeof(T), impl);

        //public static void SetImplementation(Type type, dynamic impl)
        //{
        //    ImplementationRepository[type] = impl;
        //}

        //public static void ResetToDefault()
        //{
        //    ImplementationRepository.Clear();
        //}

        //public static IDisposable UseDefaultImplementations()
        //{
        //    var oldRepository = ImplementationRepository;
        //    ImplementationRepository = new ConcurrentDictionary<Type, dynamic>();

        //    return new Disposable(() =>
        //    {
        //        ImplementationRepository = oldRepository;
        //    });
        //}

        //public static IDisposable UseDefaultImplementation<T>() => UseDefaultImplementation(typeof(T));

        //public static IDisposable UseDefaultImplementation(Type type)
        //{
        //    var oldExisted = ImplementationRepository.TryRemove(type, out dynamic old);

        //    return new Disposable(() =>
        //    {
        //        if (oldExisted)
        //        {
        //            ImplementationRepository[type] = old;
        //        }
        //        else
        //        {
        //            ImplementationRepository.TryRemove(type, out var tmp);
        //        }
        //    });
        //}
    }
}