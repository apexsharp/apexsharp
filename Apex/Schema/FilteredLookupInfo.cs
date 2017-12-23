namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FilteredLookupInfo
    {
        // infrastructure
        public FilteredLookupInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FilteredLookupInfo));
            }
        }

        // API
        List<string> controllingFields
        {
            get
            {
                return Self.controllingFields;
            }
            set
            {
                Self.controllingFields = value;
            }
        }

        bool dependent
        {
            get
            {
                return Self.dependent;
            }
            set
            {
                Self.dependent = value;
            }
        }

        bool optionalFilter
        {
            get
            {
                return Self.optionalFilter;
            }
            set
            {
                Self.optionalFilter = value;
            }
        }

        public List<string> getControllingFields()
        {
            return Self.getControllingFields();
        }

        public bool isDependent()
        {
            return Self.isDependent();
        }

        public bool isOptionalFilter()
        {
            return Self.isOptionalFilter();
        }
    }
}
