namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class PrimitiveTypes
    {
        public Blob MyBlob = Blob.valueOf("Jay");

        public bool IsWinner = true;

        public Date MyDate = Date.today();

        // public DateTime MyDateTime = DateTime.now();
        // public Decimal MyDecimal = 12.4567;
        public double d = 3.133433;

        public ID MyId = "006E0000004TquXIAS";

        public int MyInteger = 1;

        public long MyLong = 23432424242L;

        public Time MyTime = Time.newInstance(1, 2, 3, 4);

        public string MyString = "Jay";

        public string abc, def, jkl;

        public void demoMethod()
        {
            object obj = 10;
            int i = (int)obj;
            string abc1, def1, jkl1;
        }
    }
}
