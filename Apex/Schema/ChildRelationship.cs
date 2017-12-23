namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Schema_ChildRelationship.htm#apex_class_Schema_ChildRelationship
    /// </summary>
    public class ChildRelationship
    {
        // infrastructure
        public ChildRelationship(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChildRelationship));
            }
        }

        // API
        public SObjectType getChildSObject()
        {
            return Self.getChildSObject();
        }

        public SObjectField getField()
        {
            return Self.getField();
        }

        public string getRelationshipName()
        {
            return Self.getRelationshipName();
        }

        public bool isCascadeDelete()
        {
            return Self.isCascadeDelete();
        }

        public bool isDeprecatedAndHidden()
        {
            return Self.isDeprecatedAndHidden();
        }

        public bool isRestrictedDelete()
        {
            return Self.isRestrictedDelete();
        }

        bool cascadeDelete
        {
            get
            {
                return Self.cascadeDelete;
            }
            set
            {
                Self.cascadeDelete = value;
            }
        }

        SObjectType childSObject
        {
            get
            {
                return Self.childSObject;
            }
            set
            {
                Self.childSObject = value;
            }
        }

        bool deprecatedAndHidden
        {
            get
            {
                return Self.deprecatedAndHidden;
            }
            set
            {
                Self.deprecatedAndHidden = value;
            }
        }

        SObjectField field
        {
            get
            {
                return Self.field;
            }
            set
            {
                Self.field = value;
            }
        }

        List<string> junctionIdListNames
        {
            get
            {
                return Self.junctionIdListNames;
            }
            set
            {
                Self.junctionIdListNames = value;
            }
        }

        List<SObjectType> junctionReferenceTo
        {
            get
            {
                return Self.junctionReferenceTo;
            }
            set
            {
                Self.junctionReferenceTo = value;
            }
        }

        string relationshipName
        {
            get
            {
                return Self.relationshipName;
            }
            set
            {
                Self.relationshipName = value;
            }
        }

        bool restrictedDelete
        {
            get
            {
                return Self.restrictedDelete;
            }
            set
            {
                Self.restrictedDelete = value;
            }
        }

        public List<string> getJunctionIdListNames()
        {
            return Self.getJunctionIdListNames();
        }

        public List<SObjectType> getJunctionReferenceTo()
        {
            return Self.getJunctionReferenceTo();
        }
    }
}
