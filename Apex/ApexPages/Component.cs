namespace Apex.ApexPages
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_pages_dynamic_components.htm#apex_pages_dynamic_components
    /// </summary>
    public class Component
    {
        // infrastructure
        public Component(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Component));
            }
        }

        // API
        List<Component> childComponents
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

        string expressions
        {
            get
            {
                return Self.expressions;
            }
            set
            {
                Self.expressions = value;
            }
        }

        string facets
        {
            get
            {
                return Self.facets;
            }
            set
            {
                Self.facets = value;
            }
        }

        object componentIterations
        {
            get
            {
                return Self.componentIterations;
            }
            set
            {
                Self.componentIterations = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
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

        object rendered
        {
            get
            {
                return Self.rendered;
            }
            set
            {
                Self.rendered = value;
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
