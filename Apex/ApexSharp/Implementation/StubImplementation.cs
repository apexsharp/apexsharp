using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Apex.ApexSharp.Implementation
{
    /// <summary>
    /// Provides the dynamic stub implementation for any API class.
    /// </summary>
    /// <remarks>
    /// Generates error messages and throws <see cref="NotImplementedException"/>s for any invocations.
    /// </remarks>
    public class StubImplementation : DynamicObject
    {
        public StubImplementation(string className) => ClassName = className;

        public string ClassName { get; }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            throw new NotImplementedException($"get {ClassName}.{binder.Name}");
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            throw new NotImplementedException($"set {ClassName}.{binder.Name}");
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var argList = string.Join(", ", args.Select(a => a == null ? "null" : a.GetType().Name));
            throw new NotImplementedException($"{ClassName}.{binder.Name}({argList})");
        }
    }
}
