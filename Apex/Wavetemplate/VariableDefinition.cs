namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class VariableDefinition
    {
        // infrastructure
        public VariableDefinition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(VariableDefinition));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public object getComputedValue()
        {
            return Self.getComputedValue();
        }

        public object getDefaultValue()
        {
            return Self.getDefaultValue();
        }

        public string getDescription()
        {
            return Self.getDescription();
        }

        public Set<string> getExcludes()
        {
            return Self.getExcludes();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getName()
        {
            return Self.getName();
        }

        public VariableType getVariableType()
        {
            return Self.getVariableType();
        }

        public bool isExcludeSelected()
        {
            return Self.isExcludeSelected();
        }

        public bool isRequired()
        {
            return Self.isRequired();
        }

        public void setComputedValue(object computedValue)
        {
            Self.setComputedValue(computedValue);
        }

        public void setDescription(string description)
        {
            Self.setDescription(description);
        }

        public void setExcludes(Set<string> excludes)
        {
            Self.setExcludes(excludes);
        }

        public void setLabel(string label)
        {
            Self.setLabel(label);
        }

        public void setRequired(bool required)
        {
            Self.setRequired(required);
        }
    }
}
