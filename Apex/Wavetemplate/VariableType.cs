namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class VariableType
    {
        // infrastructure
        public VariableType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(VariableType));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getDataType()
        {
            return Self.getDataType();
        }

        public List<object> getEnums()
        {
            return Self.getEnums();
        }

        public VariableType getItemsType()
        {
            return Self.getItemsType();
        }

        public VariableTypeEnum getType()
        {
            return Self.getType();
        }

        public void setEnums(List<object> enums)
        {
            Self.setEnums(enums);
        }
    }
}
