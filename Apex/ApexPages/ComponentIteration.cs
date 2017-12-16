namespace Apex.ApexPages
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ComponentIteration
    {
        // infrastructure
        public ComponentIteration(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ComponentIteration));
            }
        }

        // API
        object childComponents
        {
            get
            {
                return Self.childComponents;
            }
            set
            {
                Self.childComponents = value;
            }
        }

        object iterationValue
        {
            get
            {
                return Self.iterationValue;
            }
            set
            {
                Self.iterationValue = value;
            }
        }

        object parent
        {
            get
            {
                return Self.parent;
            }
            set
            {
                Self.parent = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public Component getComponentById(string id)
        {
            return Self.getComponentById(id);
        }
    }
}
