namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_Layout.htm#apex_class_Metadata_Layout
    /// </summary>
    public class Layout
    {
        // infrastructure
        public Layout(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Layout));
            }
        }

        // API
        List<string> customButtons
        {
            get
            {
                return Self.customButtons;
            }
            set
            {
                Self.customButtons = value;
            }
        }

        CustomConsoleComponents customConsoleComponents
        {
            get
            {
                return Self.customConsoleComponents;
            }
            set
            {
                Self.customConsoleComponents = value;
            }
        }

        bool emailDefault
        {
            get
            {
                return Self.emailDefault;
            }
            set
            {
                Self.emailDefault = value;
            }
        }

        List<string> excludeButtons
        {
            get
            {
                return Self.excludeButtons;
            }
            set
            {
                Self.excludeButtons = value;
            }
        }

        FeedLayout feedLayout
        {
            get
            {
                return Self.feedLayout;
            }
            set
            {
                Self.feedLayout = value;
            }
        }

        List<LayoutHeader> headers
        {
            get
            {
                return Self.headers;
            }
            set
            {
                Self.headers = value;
            }
        }

        List<LayoutSection> layoutSections
        {
            get
            {
                return Self.layoutSections;
            }
            set
            {
                Self.layoutSections = value;
            }
        }

        MiniLayout miniLayout
        {
            get
            {
                return Self.miniLayout;
            }
            set
            {
                Self.miniLayout = value;
            }
        }

        List<string> multilineLayoutFields
        {
            get
            {
                return Self.multilineLayoutFields;
            }
            set
            {
                Self.multilineLayoutFields = value;
            }
        }

        PlatformActionList platformActionList
        {
            get
            {
                return Self.platformActionList;
            }
            set
            {
                Self.platformActionList = value;
            }
        }

        QuickActionList quickActionList
        {
            get
            {
                return Self.quickActionList;
            }
            set
            {
                Self.quickActionList = value;
            }
        }

        RelatedContent relatedContent
        {
            get
            {
                return Self.relatedContent;
            }
            set
            {
                Self.relatedContent = value;
            }
        }

        List<RelatedListItem> relatedLists
        {
            get
            {
                return Self.relatedLists;
            }
            set
            {
                Self.relatedLists = value;
            }
        }

        List<string> relatedObjects
        {
            get
            {
                return Self.relatedObjects;
            }
            set
            {
                Self.relatedObjects = value;
            }
        }

        bool runAssignmentRulesDefault
        {
            get
            {
                return Self.runAssignmentRulesDefault;
            }
            set
            {
                Self.runAssignmentRulesDefault = value;
            }
        }

        bool showEmailCheckbox
        {
            get
            {
                return Self.showEmailCheckbox;
            }
            set
            {
                Self.showEmailCheckbox = value;
            }
        }

        bool showHighlightsPanel
        {
            get
            {
                return Self.showHighlightsPanel;
            }
            set
            {
                Self.showHighlightsPanel = value;
            }
        }

        bool showInteractionLogPanel
        {
            get
            {
                return Self.showInteractionLogPanel;
            }
            set
            {
                Self.showInteractionLogPanel = value;
            }
        }

        bool showKnowledgeComponent
        {
            get
            {
                return Self.showKnowledgeComponent;
            }
            set
            {
                Self.showKnowledgeComponent = value;
            }
        }

        bool showRunAssignmentRulesCheckbox
        {
            get
            {
                return Self.showRunAssignmentRulesCheckbox;
            }
            set
            {
                Self.showRunAssignmentRulesCheckbox = value;
            }
        }

        bool showSolutionSection
        {
            get
            {
                return Self.showSolutionSection;
            }
            set
            {
                Self.showSolutionSection = value;
            }
        }

        bool showSubmitAndAttachButton
        {
            get
            {
                return Self.showSubmitAndAttachButton;
            }
            set
            {
                Self.showSubmitAndAttachButton = value;
            }
        }

        SummaryLayout summaryLayout
        {
            get
            {
                return Self.summaryLayout;
            }
            set
            {
                Self.summaryLayout = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public Layout()
        {
            Self = Implementation.Constructor();
        }
    }
}
