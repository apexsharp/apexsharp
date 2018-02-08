using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexApiAnalyzer
{
    public class MethodReference
    {
        public string Name { get; set; }

        public string Signature { get; set; }

        public string FullSignature { get; set; }

        public ClassReference Class { get; set; }

        public bool IsStatic { get; set; }

        public override string ToString() => Signature;
    }
}
