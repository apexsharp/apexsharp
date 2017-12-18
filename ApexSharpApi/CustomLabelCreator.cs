using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;

namespace ApexSharpApi
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://soap.sforce.com/2006/04/metadata")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soap.sforce.com/2006/04/metadata", IsNullable = false)]
    public partial class CustomLabels
    {

        private CustomLabelsLabels[] labelsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("labels")]
        public CustomLabelsLabels[] labels
        {
            get
            {
                return this.labelsField;
            }
            set
            {
                this.labelsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://soap.sforce.com/2006/04/metadata")]
    public partial class CustomLabelsLabels
    {

        private string fullNameField;

        private string languageField;

        private bool protectedField;

        private string shortDescriptionField;

        private string valueField;

        /// <remarks/>
        public string fullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }

        /// <remarks/>
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public bool @protected
        {
            get
            {
                return this.protectedField;
            }
            set
            {
                this.protectedField = value;
            }
        }

        /// <remarks/>
        public string shortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


    public class CustomLabelCreator
    {
        public static void CreateInstanceBinder()
        {
            string xml = File.ReadAllText(ApexSharp.GetSession().SalesForceLocation + @"\labels\CustomLabels.labels");
            var customLabels = UtilXml.DeSerilizeFromXML<CustomLabels>(xml);
            foreach (var customLabel in customLabels.labels)
            {
                Console.WriteLine(customLabel.fullName + "  " + customLabel.value);
            }
        }
    }
}
