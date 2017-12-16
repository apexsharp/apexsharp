using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Exception))]
    public class ExceptionImplementation : BaseExceptionImplementation<Exception>
    {
    }
}
