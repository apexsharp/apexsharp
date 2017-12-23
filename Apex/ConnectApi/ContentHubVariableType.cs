namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubVariableType
    {
        // infrastructure
        public ContentHubVariableType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubVariableType));
            }
        }

        // API
        object BooleanType
        {
            get
            {
                return Self.BooleanType;
            }
            set
            {
                Self.BooleanType = value;
            }
        }

        object DateTimeType
        {
            get
            {
                return Self.DateTimeType;
            }
            set
            {
                Self.DateTimeType = value;
            }
        }

        object DecimalType
        {
            get
            {
                return Self.DecimalType;
            }
            set
            {
                Self.DecimalType = value;
            }
        }

        object HtmlType
        {
            get
            {
                return Self.HtmlType;
            }
            set
            {
                Self.HtmlType = value;
            }
        }

        object IdType
        {
            get
            {
                return Self.IdType;
            }
            set
            {
                Self.IdType = value;
            }
        }

        object IntegerType
        {
            get
            {
                return Self.IntegerType;
            }
            set
            {
                Self.IntegerType = value;
            }
        }

        object StringType
        {
            get
            {
                return Self.StringType;
            }
            set
            {
                Self.StringType = value;
            }
        }

        object UriType
        {
            get
            {
                return Self.UriType;
            }
            set
            {
                Self.UriType = value;
            }
        }

        object XmlType
        {
            get
            {
                return Self.XmlType;
            }
            set
            {
                Self.XmlType = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<ContentHubVariableType> values()
        {
            return Implementation.values();
        }
    }
}
