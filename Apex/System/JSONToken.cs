namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum JSONToken
    {
        END_ARRAY,
        END_OBJECT,
        FIELD_NAME,
        NOT_AVAILABLE,
        START_ARRAY,
        START_OBJECT,
        VALUE_EMBEDDED_OBJECT,
        VALUE_FALSE,
        VALUE_NULL,
        VALUE_NUMBER_FLOAT,
        VALUE_NUMBER_INT,
        VALUE_STRING,
        VALUE_TRUE
    }
}
