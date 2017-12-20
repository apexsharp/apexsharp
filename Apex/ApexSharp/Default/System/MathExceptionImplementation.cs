using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(MathException))]
    public class MathExceptionImplementation : BaseExceptionImplementation<MathException>
    {
    }
}
