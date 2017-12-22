using System.Linq;
using Apex.ApexSharp.Implementation;
using Apex.System;
using Activator = System.Activator;
using Assembly = System.Reflection.Assembly;
using SysException = System.Exception;
using SysType = System.Type;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Type))]
    public class TypeImplementation
    {
        // Self

        public class TypeInstance
        {
            public TypeInstance(SysType type) => Type = type;

            internal SysType Type { get; }

            public bool equals(object obj)
            {
                var type = obj as Type;
                if (type == null)
                {
                    return false;
                }

                if (type.Self is TypeInstance typeInst)
                {
                    return Equals(Type, typeInst.Type);
                }

                return false;
            }

            public string getName() => Type.FullName;

            public int hashCode() => Type.GetHashCode();

            public object newInstance()
            {
                try
                {
                    return Activator.CreateInstance(Type);
                }
                catch (SysException ex)
                {
                    var cause = new Exception(ex.Message);
                    throw new TypeException($"The type doesn't have a default constructor: {getName()}.", cause);
                }
            }

            public string toString() => Type.FullName;

            public object clone() => new Type(new TypeInstance(Type));
        }

        // Implementation

        public Type forName(string fullyQualifiedName)
        {
            var type = SysType.GetType(fullyQualifiedName, throwOnError: false, ignoreCase: true);
            if (type == null)
            {
                // traverse assemblies: mscorlib, Apex, entry point, calling assembly
                var assemblies = new[]
                {
                    typeof(string).Assembly, typeof(Type).Assembly,
                    Assembly.GetEntryAssembly(),
                    Assembly.GetCallingAssembly()
                };

                foreach (var asm in assemblies.Distinct())
                {
                    type = asm.GetType(fullyQualifiedName, throwOnError: false, ignoreCase: true);
                    if (type != null)
                    {
                        break;
                    }
                }
            }

            if (type == null)
            {
                throw new TypeException($"Type not found: {fullyQualifiedName}");
            }

            var typeInst = new TypeInstance(type);
            return new Type(typeInst);
        }

        public Type forName(string @namespace, string name) => forName($"{@namespace}.{name}".TrimStart('.'));

        public SysType GetSystemType(Type apexType)
        {
            if (apexType.Self is TypeInstance typeInst)
            {
                return typeInst.Type;
            }

            throw new TypeException($"Unrecognized type: {apexType.toString()}");
        }

        public Type GetApexType(SysType systemType) => new Type(new TypeInstance(systemType));
    }
}
