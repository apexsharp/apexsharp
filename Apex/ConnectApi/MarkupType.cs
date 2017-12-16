namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MarkupType
    {
        // infrastructure
        public MarkupType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MarkupType));
            }
        }

        // API
        object Bold
        {
            get
            {
                return Self.Bold;
            }
            set
            {
                Self.Bold = value;
            }
        }

        object Code
        {
            get
            {
                return Self.Code;
            }
            set
            {
                Self.Code = value;
            }
        }

        object Italic
        {
            get
            {
                return Self.Italic;
            }
            set
            {
                Self.Italic = value;
            }
        }

        object ListItem
        {
            get
            {
                return Self.ListItem;
            }
            set
            {
                Self.ListItem = value;
            }
        }

        object OrderedList
        {
            get
            {
                return Self.OrderedList;
            }
            set
            {
                Self.OrderedList = value;
            }
        }

        object Paragraph
        {
            get
            {
                return Self.Paragraph;
            }
            set
            {
                Self.Paragraph = value;
            }
        }

        object Strikethrough
        {
            get
            {
                return Self.Strikethrough;
            }
            set
            {
                Self.Strikethrough = value;
            }
        }

        object Underline
        {
            get
            {
                return Self.Underline;
            }
            set
            {
                Self.Underline = value;
            }
        }

        object UnorderedList
        {
            get
            {
                return Self.UnorderedList;
            }
            set
            {
                Self.UnorderedList = value;
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

        public static List<MarkupType> values()
        {
            return Implementation.values();
        }
    }
}
