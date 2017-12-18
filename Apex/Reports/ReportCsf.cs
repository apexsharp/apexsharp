namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_ReportCsf.htm#apex_class_reports_ReportCsf
    /// </summary>
    public class ReportCsf
    {
        // infrastructure
        public ReportCsf(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReportCsf));
            }
        }

        // API
        public ReportCsf(string label, string description, FormulaType formulaType, int decimalPlaces, string downGroup, CsfGroupType downGroupType, string acrossGroup, CsfGroupType acrossGroupType, string formula)
        {
            Self = Implementation.Constructor(label, description, formulaType, decimalPlaces, downGroup, downGroupType, acrossGroup, acrossGroupType, formula);
        }

        public ReportCsf()
        {
            Self = Implementation.Constructor();
        }

        public string getAcrossGroup()
        {
            return Self.getAcrossGroup();
        }

        public CsfGroupType getAcrossGroupType()
        {
            return Self.getAcrossGroupType();
        }

        public int getDecimalPlaces()
        {
            return Self.getDecimalPlaces();
        }

        public string getDescription()
        {
            return Self.getDescription();
        }

        public string getDownGroup()
        {
            return Self.getDownGroup();
        }

        public CsfGroupType getDownGroupType()
        {
            return Self.getDownGroupType();
        }

        public string getFormula()
        {
            return Self.getFormula();
        }

        public FormulaType getFormulaType()
        {
            return Self.getFormulaType();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public void setAcrossGroup(string acrossGroup)
        {
            Self.setAcrossGroup(acrossGroup);
        }

        public void setAcrossGroupType(string value)
        {
            Self.setAcrossGroupType(value);
        }

        public void setAcrossGroupType(CsfGroupType acrossGroupType)
        {
            Self.setAcrossGroupType(acrossGroupType);
        }

        public void setDecimalPlaces(int decimalPlaces)
        {
            Self.setDecimalPlaces(decimalPlaces);
        }

        public void setDescription(string description)
        {
            Self.setDescription(description);
        }

        public void setDownGroup(string downGroup)
        {
            Self.setDownGroup(downGroup);
        }

        public void setDownGroupType(string value)
        {
            Self.setDownGroupType(value);
        }

        public void setDownGroupType(CsfGroupType downGroupType)
        {
            Self.setDownGroupType(downGroupType);
        }

        public void setFormula(string formula)
        {
            Self.setFormula(formula);
        }

        public void setFormulaType(string value)
        {
            Self.setFormulaType(value);
        }

        public void setFormulaType(FormulaType formulaType)
        {
            Self.setFormulaType(formulaType);
        }

        public void setLabel(string label)
        {
            Self.setLabel(label);
        }

        public string toString()
        {
            return Self.toString();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
