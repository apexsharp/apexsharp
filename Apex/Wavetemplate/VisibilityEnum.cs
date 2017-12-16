namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class VisibilityEnum
    {
        // infrastructure
        public VisibilityEnum(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(VisibilityEnum));
            }
        }

        // API
        object Disabled
        {
            get
            {
                return Self.Disabled;
            }
            set
            {
                Self.Disabled = value;
            }
        }

        object Hidden
        {
            get
            {
                return Self.Hidden;
            }
            set
            {
                Self.Hidden = value;
            }
        }

        object Visible
        {
            get
            {
                return Self.Visible;
            }
            set
            {
                Self.Visible = value;
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

        public static List<VisibilityEnum> values()
        {
            return Implementation.values();
        }
    }
}
