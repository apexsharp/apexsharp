using Apex.ApexSharp.Implementation;
using Apex.System;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(DmlException))]
    public class DmlExceptionImplementation : BaseExceptionImplementation<DmlException>
    {
    }
}
