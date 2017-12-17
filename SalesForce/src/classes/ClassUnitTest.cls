@IsTest
public class ClassUnitTest
{
    @TestSetup
    public static void setup()
    {
        System.debug('Setup Got Called');
    }

    @IsTest
    public static void assert()
    {
        System.assert(true, 'Assert True');
    }

    @IsTest
    public static void assertTestMethod()
    {
        System.assert(true, 'Assert True');
    }

    @IsTest
    public static void assertEquals()
    {
        System.assertEquals(5, 5, 'Assert Equal');
    }

    @IsTest
    public static void assertEqualsTestMethod()
    {
        System.assertEquals(5, 5, 'Assert Equal');
    }

    @IsTest
    public static void assertNotEquals()
    {
        System.assertNotEquals(5, 0, 'Assert Not Equal');
    }

    @IsTest
    public static void assertNotTestMethod()
    {
        System.assertNotEquals(5, 0, 'Assert Not Equal');
    }
}