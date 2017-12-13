namespace Apex.System
{
    public class WebServiceCallout
    {
        public static object beginInvoke<T>(object stub, object request, object returnType, object continuation,
            List<T> info)
        {
            throw new global::System.NotImplementedException("WebServiceCallout.BeginInvoke");
        }

        public static object endInvoke(object future)
        {
            throw new global::System.NotImplementedException("WebServiceCallout.EndInvoke");
        }

        public static void invoke<T, K>(object stub, object request, Map<T, K> response, List<T> info)
        {
            throw new global::System.NotImplementedException("WebServiceCallout.Invoke");
        }
    }
}