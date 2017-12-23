namespace Apex.Predictive
{
    using ApexSharp.Implementation;
    using System;

    public class Row
    {
        // infrastructure
        public Row(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Row));
            }
        }

        // API
        public Row()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public Map<String, object> getCells()
        {
            return Self.getCells();
        }

        public void setCells(Map<String, object> cells)
        {
            Self.setCells(cells);
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}