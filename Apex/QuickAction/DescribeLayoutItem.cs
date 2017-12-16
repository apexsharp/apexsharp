namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_describelayoutitem.htm#apex_class_quickaction_describelayoutitem
    /// </summary>
    public class DescribeLayoutItem
    {
        // infrastructure
        public DescribeLayoutItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeLayoutItem));
            }
        }

        // API
        public string getLabel()
        {
            return Self.getLabel();
        }

        public List<DescribeLayoutComponent> getLayoutComponents()
        {
            return Self.getLayoutComponents();
        }

        public bool isEditable()
        {
            return Self.isEditable();
        }

        public bool isPlaceholder()
        {
            return Self.isPlaceholder();
        }

        public bool isRequired()
        {
            return Self.isRequired();
        }

        bool editableForNew
        {
            get
            {
                return Self.editableForNew;
            }
            set
            {
                Self.editableForNew = value;
            }
        }

        bool editableForUpdate
        {
            get
            {
                return Self.editableForUpdate;
            }
            set
            {
                Self.editableForUpdate = value;
            }
        }

        string label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        List<DescribeLayoutComponent> layoutComponents
        {
            get
            {
                return Self.layoutComponents;
            }
            set
            {
                Self.layoutComponents = value;
            }
        }

        bool placeholder
        {
            get
            {
                return Self.placeholder;
            }
            set
            {
                Self.placeholder = value;
            }
        }

        bool required
        {
            get
            {
                return Self.required;
            }
            set
            {
                Self.required = value;
            }
        }

        public bool isEditableForNew()
        {
            return Self.isEditableForNew();
        }

        public bool isEditableForUpdate()
        {
            return Self.isEditableForUpdate();
        }
    }
}
