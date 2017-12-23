namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;

    /// <summary>
    ///
    /// </summary>
    public class Trigger
    {
        // infrastructure
        public Trigger(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Trigger));
            }
        }

        // API
        static bool isAfter
        {
            get
            {
                return Implementation.isAfter;
            }
            set
            {
                Implementation.isAfter = value;
            }
        }

        static bool isBefore
        {
            get
            {
                return Implementation.isBefore;
            }
            set
            {
                Implementation.isBefore = value;
            }
        }

        static bool isDelete
        {
            get
            {
                return Implementation.isDelete;
            }
            set
            {
                Implementation.isDelete = value;
            }
        }

        static bool isExecuting
        {
            get
            {
                return Implementation.isExecuting;
            }
            set
            {
                Implementation.isExecuting = value;
            }
        }

        static bool isInsert
        {
            get
            {
                return Implementation.isInsert;
            }
            set
            {
                Implementation.isInsert = value;
            }
        }

        static bool isUndelete
        {
            get
            {
                return Implementation.isUndelete;
            }
            set
            {
                Implementation.isUndelete = value;
            }
        }

        static bool isUpdate
        {
            get
            {
                return Implementation.isUpdate;
            }
            set
            {
                Implementation.isUpdate = value;
            }
        }

        static List<SObject> @new
        {
            get
            {
                return Implementation.@new;
            }
            set
            {
                Implementation.@new = value;
            }
        }

        static Map<ID, SObject> newMap
        {
            get
            {
                return Implementation.newMap;
            }
            set
            {
                Implementation.newMap = value;
            }
        }

        static List<SObject> old
        {
            get
            {
                return Implementation.old;
            }
            set
            {
                Implementation.old = value;
            }
        }

        static Map<ID, SObject> oldMap
        {
            get
            {
                return Implementation.oldMap;
            }
            set
            {
                Implementation.oldMap = value;
            }
        }

        static int size
        {
            get
            {
                return Implementation.size;
            }
            set
            {
                Implementation.size = value;
            }
        }
    }
}
