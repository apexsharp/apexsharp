namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class ObjectRefreshStatus
    {
        // infrastructure
        public ObjectRefreshStatus(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ObjectRefreshStatus));
            }
        }

        // API
        public ObjectRefreshStatus()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<string> getDebugInfo()
        {
            return Self.getDebugInfo();
        }

        public Datetime getEndTime()
        {
            return Self.getEndTime();
        }

        public List<string> getErrors()
        {
            return Self.getErrors();
        }

        public ObjectTreatment getObjectTreatment()
        {
            return Self.getObjectTreatment();
        }

        public string getRefreshId()
        {
            return Self.getRefreshId();
        }

        public Datetime getStartTime()
        {
            return Self.getStartTime();
        }

        public ObjectRefreshState getState()
        {
            return Self.getState();
        }

        public List<string> getWarnings()
        {
            return Self.getWarnings();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}