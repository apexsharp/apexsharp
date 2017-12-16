namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FilePreviewFormat
    {
        // infrastructure
        public FilePreviewFormat(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FilePreviewFormat));
            }
        }

        // API
        object Pdf
        {
            get
            {
                return Self.Pdf;
            }
            set
            {
                Self.Pdf = value;
            }
        }

        object Svg
        {
            get
            {
                return Self.Svg;
            }
            set
            {
                Self.Svg = value;
            }
        }

        object Thumbnail
        {
            get
            {
                return Self.Thumbnail;
            }
            set
            {
                Self.Thumbnail = value;
            }
        }

        object ThumbnailBig
        {
            get
            {
                return Self.ThumbnailBig;
            }
            set
            {
                Self.ThumbnailBig = value;
            }
        }

        object ThumbnailTiny
        {
            get
            {
                return Self.ThumbnailTiny;
            }
            set
            {
                Self.ThumbnailTiny = value;
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

        public static List<FilePreviewFormat> values()
        {
            return Implementation.values();
        }
    }
}
