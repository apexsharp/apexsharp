namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_describequickactionresult.htm#apex_class_quickaction_describequickactionresult
    /// </summary>
    public class DescribeQuickActionResult
    {
        // infrastructure
        public DescribeQuickActionResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeQuickActionResult));
            }
        }

        // API
        string canvasapplicationname
        {
            get
            {
                return Self.canvasapplicationname;
            }
            set
            {
                Self.canvasapplicationname = value;
            }
        }

        List<DescribeColorResult> colors
        {
            get
            {
                return Self.colors;
            }
            set
            {
                Self.colors = value;
            }
        }

        string contextsobjecttype
        {
            get
            {
                return Self.contextsobjecttype;
            }
            set
            {
                Self.contextsobjecttype = value;
            }
        }

        List<DescribeQuickActionDefaultValue> defaultvalues
        {
            get
            {
                return Self.defaultvalues;
            }
            set
            {
                Self.defaultvalues = value;
            }
        }

        string flowdevname
        {
            get
            {
                return Self.flowdevname;
            }
            set
            {
                Self.flowdevname = value;
            }
        }

        string flowrecordidvar
        {
            get
            {
                return Self.flowrecordidvar;
            }
            set
            {
                Self.flowrecordidvar = value;
            }
        }

        int height
        {
            get
            {
                return Self.height;
            }
            set
            {
                Self.height = value;
            }
        }

        string iconname
        {
            get
            {
                return Self.iconname;
            }
            set
            {
                Self.iconname = value;
            }
        }

        List<DescribeIconResult> icons
        {
            get
            {
                return Self.icons;
            }
            set
            {
                Self.icons = value;
            }
        }

        string iconurl
        {
            get
            {
                return Self.iconurl;
            }
            set
            {
                Self.iconurl = value;
            }
        }

        DescribeLayoutSection layout
        {
            get
            {
                return Self.layout;
            }
            set
            {
                Self.layout = value;
            }
        }

        string lightningcomponentbundleid
        {
            get
            {
                return Self.lightningcomponentbundleid;
            }
            set
            {
                Self.lightningcomponentbundleid = value;
            }
        }

        string lightningcomponentbundlename
        {
            get
            {
                return Self.lightningcomponentbundlename;
            }
            set
            {
                Self.lightningcomponentbundlename = value;
            }
        }

        string lightningcomponentqualifiedname
        {
            get
            {
                return Self.lightningcomponentqualifiedname;
            }
            set
            {
                Self.lightningcomponentqualifiedname = value;
            }
        }

        string miniiconurl
        {
            get
            {
                return Self.miniiconurl;
            }
            set
            {
                Self.miniiconurl = value;
            }
        }

        bool showquickactionlcheader
        {
            get
            {
                return Self.showquickactionlcheader;
            }
            set
            {
                Self.showquickactionlcheader = value;
            }
        }

        bool showquickactionvfheader
        {
            get
            {
                return Self.showquickactionvfheader;
            }
            set
            {
                Self.showquickactionvfheader = value;
            }
        }

        string targetparentfield
        {
            get
            {
                return Self.targetparentfield;
            }
            set
            {
                Self.targetparentfield = value;
            }
        }

        string targetrecordtypeid
        {
            get
            {
                return Self.targetrecordtypeid;
            }
            set
            {
                Self.targetrecordtypeid = value;
            }
        }

        string targetsobjecttype
        {
            get
            {
                return Self.targetsobjecttype;
            }
            set
            {
                Self.targetsobjecttype = value;
            }
        }

        string visualforcepagename
        {
            get
            {
                return Self.visualforcepagename;
            }
            set
            {
                Self.visualforcepagename = value;
            }
        }

        string visualforcepageurl
        {
            get
            {
                return Self.visualforcepageurl;
            }
            set
            {
                Self.visualforcepageurl = value;
            }
        }

        int width
        {
            get
            {
                return Self.width;
            }
            set
            {
                Self.width = value;
            }
        }

        public string getActionEnumOrId()
        {
            return Self.getActionEnumOrId();
        }

        public List<DescribeColorResult> getColors()
        {
            return Self.getColors();
        }

        public string getContextSobjectType()
        {
            return Self.getContextSobjectType();
        }

        public List<DescribeQuickActionDefaultValue> getDefaultValues()
        {
            return Self.getDefaultValues();
        }

        public string getFlowDevName()
        {
            return Self.getFlowDevName();
        }

        public string getFlowRecordIdVar()
        {
            return Self.getFlowRecordIdVar();
        }

        public int getHeight()
        {
            return Self.getHeight();
        }

        public string getIconName()
        {
            return Self.getIconName();
        }

        public string getIconUrl()
        {
            return Self.getIconUrl();
        }

        public List<DescribeIconResult> getIcons()
        {
            return Self.getIcons();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public DescribeLayoutSection getLayout()
        {
            return Self.getLayout();
        }

        public string getLightningComponentBundleId()
        {
            return Self.getLightningComponentBundleId();
        }

        public string getLightningComponentBundleName()
        {
            return Self.getLightningComponentBundleName();
        }

        public string getLightningComponentQualifiedName()
        {
            return Self.getLightningComponentQualifiedName();
        }

        public string getMiniIconUrl()
        {
            return Self.getMiniIconUrl();
        }

        public string getName()
        {
            return Self.getName();
        }

        public bool getShowQuickActionLcHeader()
        {
            return Self.getShowQuickActionLcHeader();
        }

        public bool getShowQuickActionVfHeader()
        {
            return Self.getShowQuickActionVfHeader();
        }

        public string getSourceSobjectType()
        {
            return Self.getSourceSobjectType();
        }

        public string getTargetParentField()
        {
            return Self.getTargetParentField();
        }

        public string getTargetRecordTypeId()
        {
            return Self.getTargetRecordTypeId();
        }

        public string getTargetSobjectType()
        {
            return Self.getTargetSobjectType();
        }

        public string getType()
        {
            return Self.getType();
        }

        public string getVisualforcePageName()
        {
            return Self.getVisualforcePageName();
        }

        public string getVisualforcePageUrl()
        {
            return Self.getVisualforcePageUrl();
        }

        public int getWidth()
        {
            return Self.getWidth();
        }

        string accessLevelRequired
        {
            get
            {
                return Self.accessLevelRequired;
            }
            set
            {
                Self.accessLevelRequired = value;
            }
        }

        string canvasApplicationId
        {
            get
            {
                return Self.canvasApplicationId;
            }
            set
            {
                Self.canvasApplicationId = value;
            }
        }

        string canvasApplicationName
        {
            get
            {
                return Self.canvasApplicationName;
            }
            set
            {
                Self.canvasApplicationName = value;
            }
        }

        string contextSobjectType
        {
            get
            {
                return Self.contextSobjectType;
            }
            set
            {
                Self.contextSobjectType = value;
            }
        }

        List<DescribeQuickActionDefaultValue> defaultValues
        {
            get
            {
                return Self.defaultValues;
            }
            set
            {
                Self.defaultValues = value;
            }
        }

        string flowDevName
        {
            get
            {
                return Self.flowDevName;
            }
            set
            {
                Self.flowDevName = value;
            }
        }

        string flowRecordIdVar
        {
            get
            {
                return Self.flowRecordIdVar;
            }
            set
            {
                Self.flowRecordIdVar = value;
            }
        }

        string iconName
        {
            get
            {
                return Self.iconName;
            }
            set
            {
                Self.iconName = value;
            }
        }

        string iconUrl
        {
            get
            {
                return Self.iconUrl;
            }
            set
            {
                Self.iconUrl = value;
            }
        }

        string lightningComponentBundleId
        {
            get
            {
                return Self.lightningComponentBundleId;
            }
            set
            {
                Self.lightningComponentBundleId = value;
            }
        }

        string lightningComponentBundleName
        {
            get
            {
                return Self.lightningComponentBundleName;
            }
            set
            {
                Self.lightningComponentBundleName = value;
            }
        }

        string lightningComponentQualifiedName
        {
            get
            {
                return Self.lightningComponentQualifiedName;
            }
            set
            {
                Self.lightningComponentQualifiedName = value;
            }
        }

        string miniIconUrl
        {
            get
            {
                return Self.miniIconUrl;
            }
            set
            {
                Self.miniIconUrl = value;
            }
        }

        bool showQuickActionLcHeader
        {
            get
            {
                return Self.showQuickActionLcHeader;
            }
            set
            {
                Self.showQuickActionLcHeader = value;
            }
        }

        bool showQuickActionVfHeader
        {
            get
            {
                return Self.showQuickActionVfHeader;
            }
            set
            {
                Self.showQuickActionVfHeader = value;
            }
        }

        string targetParentField
        {
            get
            {
                return Self.targetParentField;
            }
            set
            {
                Self.targetParentField = value;
            }
        }

        string targetRecordTypeId
        {
            get
            {
                return Self.targetRecordTypeId;
            }
            set
            {
                Self.targetRecordTypeId = value;
            }
        }

        string targetSobjectType
        {
            get
            {
                return Self.targetSobjectType;
            }
            set
            {
                Self.targetSobjectType = value;
            }
        }

        string visualforcePageName
        {
            get
            {
                return Self.visualforcePageName;
            }
            set
            {
                Self.visualforcePageName = value;
            }
        }

        string visualforcePageUrl
        {
            get
            {
                return Self.visualforcePageUrl;
            }
            set
            {
                Self.visualforcePageUrl = value;
            }
        }

        public string getAccessLevelRequired()
        {
            return Self.getAccessLevelRequired();
        }

        public string getCanvasApplicationId()
        {
            return Self.getCanvasApplicationId();
        }

        public string getCanvasApplicationName()
        {
            return Self.getCanvasApplicationName();
        }
    }
}
