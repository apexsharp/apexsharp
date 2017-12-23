namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PlatformActionListContextEnum
    {
        // infrastructure
        public PlatformActionListContextEnum(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PlatformActionListContextEnum));
            }
        }

        // API
        object Assistant
        {
            get
            {
                return Self.Assistant;
            }
            set
            {
                Self.Assistant = value;
            }
        }

        object BannerPhoto
        {
            get
            {
                return Self.BannerPhoto;
            }
            set
            {
                Self.BannerPhoto = value;
            }
        }

        object Chatter
        {
            get
            {
                return Self.Chatter;
            }
            set
            {
                Self.Chatter = value;
            }
        }

        object Dockable
        {
            get
            {
                return Self.Dockable;
            }
            set
            {
                Self.Dockable = value;
            }
        }

        object FeedElement
        {
            get
            {
                return Self.FeedElement;
            }
            set
            {
                Self.FeedElement = value;
            }
        }

        object Flexipage
        {
            get
            {
                return Self.Flexipage;
            }
            set
            {
                Self.Flexipage = value;
            }
        }

        object Global_x
        {
            get
            {
                return Self.Global_x;
            }
            set
            {
                Self.Global_x = value;
            }
        }

        object ListView
        {
            get
            {
                return Self.ListView;
            }
            set
            {
                Self.ListView = value;
            }
        }

        object ListViewDefinition
        {
            get
            {
                return Self.ListViewDefinition;
            }
            set
            {
                Self.ListViewDefinition = value;
            }
        }

        object ListViewRecord
        {
            get
            {
                return Self.ListViewRecord;
            }
            set
            {
                Self.ListViewRecord = value;
            }
        }

        object Lookup
        {
            get
            {
                return Self.Lookup;
            }
            set
            {
                Self.Lookup = value;
            }
        }

        object MruList
        {
            get
            {
                return Self.MruList;
            }
            set
            {
                Self.MruList = value;
            }
        }

        object MruRow
        {
            get
            {
                return Self.MruRow;
            }
            set
            {
                Self.MruRow = value;
            }
        }

        object ObjectHomeChart
        {
            get
            {
                return Self.ObjectHomeChart;
            }
            set
            {
                Self.ObjectHomeChart = value;
            }
        }

        object Photo
        {
            get
            {
                return Self.Photo;
            }
            set
            {
                Self.Photo = value;
            }
        }

        object Record
        {
            get
            {
                return Self.Record;
            }
            set
            {
                Self.Record = value;
            }
        }

        object RecordEdit
        {
            get
            {
                return Self.RecordEdit;
            }
            set
            {
                Self.RecordEdit = value;
            }
        }

        object RelatedList
        {
            get
            {
                return Self.RelatedList;
            }
            set
            {
                Self.RelatedList = value;
            }
        }

        object RelatedListRecord
        {
            get
            {
                return Self.RelatedListRecord;
            }
            set
            {
                Self.RelatedListRecord = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<PlatformActionListContextEnum> values()
        {
            return Implementation.values();
        }
    }
}
