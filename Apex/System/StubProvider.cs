namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_System_StubProvider.htm#apex_interface_System_StubProvider
    /// </summary>
    public interface StubProvider
    {
        object handleMethodCall(object stubbedObject, string stubbedMethodName, Type returnType, List<Type> listOfParamTypes, List<string> listOfParamNames, List<object> var6);
    }
}
