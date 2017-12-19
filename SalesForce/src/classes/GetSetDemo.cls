public class GetSetDemo
{
    public Double MyReadWritePropPublic { get; set; }

    private Integer propPrvt;

    public Integer prop
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

    public Integer MyReadOnlyProp { get; }

    private static Integer myStaticPropPrvt;

    public static Integer MyStaticProp
    {
        get
        {
            return myStaticPropPrvt;
        }
    }

    Integer MyReadOnlyPropPrvt { get; }

    Double MyReadWritePropPrvt { get; set; }

    public String MyWriteOnlyProp { get; }

    protected String MyWriteOnlyPropPrvt { get; set; }

    private String namePrvt;

    public String getName
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

    public String Stubbing
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

    public String DoThrowWhenException
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
