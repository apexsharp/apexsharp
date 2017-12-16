namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class VariableTypeEnum
    {
        // infrastructure
        public VariableTypeEnum(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(VariableTypeEnum));
            }
        }

        // API
        object ArrayType
        {
            get
            {
                return Self.ArrayType;
            }
            set
            {
                Self.ArrayType = value;
            }
        }

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

        object DatasetDateType
        {
            get
            {
                return Self.DatasetDateType;
            }
            set
            {
                Self.DatasetDateType = value;
            }
        }

        object DatasetDimensionType
        {
            get
            {
                return Self.DatasetDimensionType;
            }
            set
            {
                Self.DatasetDimensionType = value;
            }
        }

        object DatasetMeasureType
        {
            get
            {
                return Self.DatasetMeasureType;
            }
            set
            {
                Self.DatasetMeasureType = value;
            }
        }

        object DatasetType
        {
            get
            {
                return Self.DatasetType;
            }
            set
            {
                Self.DatasetType = value;
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

        object NumberType
        {
            get
            {
                return Self.NumberType;
            }
            set
            {
                Self.NumberType = value;
            }
        }

        object ObjectType
        {
            get
            {
                return Self.ObjectType;
            }
            set
            {
                Self.ObjectType = value;
            }
        }

        object SobjectFieldType
        {
            get
            {
                return Self.SobjectFieldType;
            }
            set
            {
                Self.SobjectFieldType = value;
            }
        }

        object SobjectType
        {
            get
            {
                return Self.SobjectType;
            }
            set
            {
                Self.SobjectType = value;
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

        public static List<VariableTypeEnum> values()
        {
            return Implementation.values();
        }
    }
}
