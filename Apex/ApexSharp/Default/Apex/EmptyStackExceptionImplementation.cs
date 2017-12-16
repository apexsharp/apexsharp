namespace Apex.ApexSharp.Implementation.Default.Apex
{
    using System;
    using global::Apex.Apex;
    using global::Apex.ApexSharp.Default.System;

    [Implements(typeof(EmptyStackException))]
    public class EmptyStackExceptionImplementation : BaseExceptionImplementation<EmptyStackException>
    {
        public EmptyStackExceptionImplementation() : base("The stack is empty.")
        {
        }
    }
}

