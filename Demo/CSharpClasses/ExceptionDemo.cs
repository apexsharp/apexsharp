namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class ExceptionDemo
    {
        public static void catchDemo()
        {
            try
            {
                throwDemo();
            }
            catch (MathException e)
            {
                System.debug(e.getMessage());
            }
            finally
            {
                System.debug("Finally");
            }
        }

        public static void throwDemo()
        {
            throw new MathException("something bad happened!");
        }
    }
}
