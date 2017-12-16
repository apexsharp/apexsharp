namespace Apex.Canvas
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public interface CanvasLifecycleHandler
    {
        Set<ContextTypeEnum> excludeContextTypes();

        void onRender(RenderContext param1);
    }
}
