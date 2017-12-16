namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LightningExtensionInformation
    {
        // infrastructure
        public LightningExtensionInformation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LightningExtensionInformation));
            }
        }

        // API
        object compositionComponent
        {
            get
            {
                return Self.compositionComponent;
            }
            set
            {
                Self.compositionComponent = value;
            }
        }

        object headerTextLabel
        {
            get
            {
                return Self.headerTextLabel;
            }
            set
            {
                Self.headerTextLabel = value;
            }
        }

        object hoverTextLabel
        {
            get
            {
                return Self.hoverTextLabel;
            }
            set
            {
                Self.hoverTextLabel = value;
            }
        }

        object renderComponent
        {
            get
            {
                return Self.renderComponent;
            }
            set
            {
                Self.renderComponent = value;
            }
        }

        public LightningExtensionInformation()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
