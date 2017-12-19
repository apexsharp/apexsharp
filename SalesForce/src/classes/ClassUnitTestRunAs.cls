public class ClassUnitTestRunAs
{
    static void RunAsExample()
    {
        User newUser = [SELECT Id FROM User LIMIT 1];
        System.runAs(newUser)
        {
        }
    }
}
