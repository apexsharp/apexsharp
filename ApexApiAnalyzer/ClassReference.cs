using System;
using System.Collections.Generic;

namespace ApexApiAnalyzer
{
    public class ClassReference
    {
        public string Namespace { get; set; }

        public string Name { get; set; }

        public bool HasImplementation { get; set; }

        public Dictionary<string, ConstructorReference> Constructors { get; set; } =
            new Dictionary<string, ConstructorReference>(StringComparer.InvariantCultureIgnoreCase);

        public Dictionary<string, MethodReference> Methods { get; set; } =
            new Dictionary<string, MethodReference>(StringComparer.InvariantCultureIgnoreCase);

        public Dictionary<string, PropertyReference> Properties { get; set; } =
            new Dictionary<string, PropertyReference>(StringComparer.InvariantCultureIgnoreCase);
    }
}
