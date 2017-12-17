public class ForIfWhile
{
    public void methodIfClean(Integer place)
    {
        String modelColor;
        if (place == 1)
        {
            modelColor = 'Gold';
        }
        else if (place == 2)
        {
            modelColor = 'Silver';
        }
        else if (place == 3)
        {
            modelColor = 'Bronze';
        }
        else
        {
            modelColor = null;
        }
    }

    public void methodForTraditional()
    {
        for (Integer i = 0; i < 10; i++)
        {
            System.debug (i + 1);
        }
    }

    public void methodForIteration()
    {
        Integer[] myInts = new Integer[5];
        for (Integer myInt : myInts)
        {
            System.debug (myInt);
        }
    }

    public void methodDo()
    {
        Integer count = 1;
        do
        {
            System.debug (count);
            count++;
        }
        while (count < 11);
    }

    public void methodWhile()
    {
        Integer count = 1;
        while (count < 11)
        {
            System.debug (count);
            count++;
        }
    }

    public void forLoopTest()
    {
        for (Integer i = 0; i < 10; i++)
        {
            System.debug (i + 1);
        }
    }

    // Nested If
    public static String getContact(String nameString)
    {
        if (nameString.length()> 0)
        {
            if (nameString.length()== 1)
            {
                return 'Gold';
            }
            else if (nameString.length()== 2)
            {
                return 'Silver';
            }
            else
            {
                return 'Nothing';
            }
        }
        else if (nameString.length()> 0)
        {
            return nameString;
        }
        else
        {
            return '';
        }
    }
}