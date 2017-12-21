namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    
    using SObjects;

    public class ForIfWhile
    {
        public void methodIfClean(int place)
        {
            string modelColor;
            if (place == 1)
            {
                modelColor = "Gold";
            }
            else if (place == 2)
            {
                modelColor = "Silver";
            }
            else if (place == 3)
            {
                modelColor = "Bronze";
            }
            else
            {
                modelColor = null;
            }
        }

        public void methodForTraditional()
        {
            for (int i = 0; i < 10; i++)
            {
                System.debug (i + 1);
            }
        }

        public void methodForIteration()
        {
            int[] myInts = new int[5];
            foreach (int myInt in myInts)
            {
                System.debug (myInt);
            }
        }

        public void methodDo()
        {
            int count = 1;
            do
            {
                System.debug (count);
                count++;
            }
            while (count < 11);
        }

        public void methodWhile()
        {
            int count = 1;
            while (count < 11)
            {
                System.debug (count);
                count++;
            }
        }

        public void forLoopTest()
        {
            for (int i = 0; i < 10; i++)
            {
                System.debug (i + 1);
            }
        }

        // Nested If
        public static string getContact(string nameString)
        {
            if (nameString.length()> 0)
            {
                if (nameString.length()== 1)
                {
                    return "Gold";
                }
                else if (nameString.length()== 2)
                {
                    return "Silver";
                }
                else
                {
                    return "Nothing";
                }
            }
            else if (nameString.length()> 0)
            {
                return nameString;
            }
            else
            {
                return "";
            }
        }
    }
}
