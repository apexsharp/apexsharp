using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(TypeException))]
    public class TypeExceptionImplementation : BaseExceptionImplementation<TypeException>
    {
        public TypeExceptionImplementation() : base("Type not found.")
        {
        }
    }
}
