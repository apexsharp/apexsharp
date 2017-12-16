namespace Apex.Canvas
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public interface EnvironmentContext
    {
        void addEntityField(string param1);

        void addEntityFields(Set<string> param1);

        string getDisplayLocation();

        List<string> getEntityFields();

        string getLocationUrl();

        string getParametersAsJSON();

        string getSublocation();

        void setParametersAsJSON(string param1);
    }
}
