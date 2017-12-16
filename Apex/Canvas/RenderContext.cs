namespace Apex.Canvas
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public interface RenderContext
    {
        ApplicationContext getApplicationContext();

        EnvironmentContext getEnvironmentContext();
    }
}
