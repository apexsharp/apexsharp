namespace Apex.Canvas
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public interface ApplicationContext
    {
        string getCanvasUrl();

        string getDeveloperName();

        string getName();

        string getNamespace();

        string getVersion();

        void setCanvasUrlPath(string param1);
    }
}
