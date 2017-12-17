public class ClassInternal
{
    InternalClassOne classOne = new InternalClassOne();

    ClassInternal.InternalClassTwo classTwo = new ClassInternal.InternalClassTwo();

    public class InternalClassOne
    {
    }

    public class InternalClassTwo
    {
    }
}