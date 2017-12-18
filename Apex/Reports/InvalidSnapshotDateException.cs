namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InvalidSnapshotDateException
    {
        // infrastructure
        public InvalidSnapshotDateException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InvalidSnapshotDateException));
            }
        }

        // API
        public InvalidSnapshotDateException()
        {
            Self = Implementation.Constructor();
        }

        public InvalidSnapshotDateException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidSnapshotDateException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InvalidSnapshotDateException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<string> getSnapshotDateErrors()
        {
            return Self.getSnapshotDateErrors();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}
