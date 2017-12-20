public abstract class MethodAndConstructor
{
    public abstract void MethodThree();

    MethodAndConstructor()
    {
    }

    public MethodAndConstructor(String demo)
    {
    }

    public virtual void VirtualMethod()
    {
    }

    @Future
    public static void FutureMethod()
    {
    }

    @Future(callout=true)
    public static void FutureMethodWithCallOut()
    {
    }

    void StringVoid()
    {
    }

    private void StringPrivateVoid()
    {
    }

    public void StringPublic()
    {
    }

    String GetString()
    {
        return 'Hello World';
    }

    public String GetStringPublic()
    {
        return 'Hello World';
    }

    private String GetStringprivate()
    {
        return 'Hello World';
    }

    public String GetStringglobal()
    {
        return 'Hello World';
    }

    List<String> GetGenericList()
    {
        return new List<String>();
    }

    Map<String, String> GetGenericMap()
    {
        return new Map<String, String>();
    }

    void arrayMethodTwoPrivate(List<String> stringArray)
    {
    }

    public static Map<String, String> arrayMethodOne(Map<String, String> stringArray, List<String> stringArrayList)
    {
        return null;
    }

    public static void arrayMethodTwo(List<String> stringArray)
    {
    }

    public Map<String, String> methodReturnMap(Map<String, String> mapList)
    {
        return null;
    }
}
