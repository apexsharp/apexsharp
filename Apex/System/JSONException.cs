namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class JSONException : Exception
    {
        // infrastructure
        public JSONException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(JSONException));
            }
        }

        // API
        public JSONException()
        {
            Self = Implementation.Constructor();
        }

        public JSONException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public JSONException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public JSONException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
