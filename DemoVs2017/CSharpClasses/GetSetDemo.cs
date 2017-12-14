namespace DemoVs2017.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class GetSetDemo
    {
        public double MyReadWritePropPublic { get; set; }

        private int propPrvt;

        public int prop
        {
            get
            {
                return propPrvt;
            }
            set
            {
                propPrvt = value;
            }
        }

        public int MyReadOnlyProp { get; }

        private static int myStaticPropPrvt;

        public static int MyStaticProp
        {
            get
            {
                return myStaticPropPrvt;
            }
        }

        int MyReadOnlyPropPrvt { get; }

        double MyReadWritePropPrvt { get; set; }

        public string MyWriteOnlyProp { get; }

        protected string MyWriteOnlyPropPrvt { get; set; }

        private string namePrvt;

        public string getName
        {
            get
            {
                return namePrvt;
            }
            private set
            {
                namePrvt = value;
            }
        }

        public string Stubbing
        {
            private get
            {
                return namePrvt;
            }
            set
            {
                namePrvt = value;
            }
        }

        public string DoThrowWhenException
        {
            get
            {
                return namePrvt;
            }
            set
            {
                namePrvt = value;
            }
        }
    }
}
