namespace Apex.Canvas
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Test
    {
        // infrastructure
        public Test(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Test));
            }
        }

        // API
        object KEY_CANVAS_URL
        {
            get
            {
                return Self.KEY_CANVAS_URL;
            }
            set
            {
                Self.KEY_CANVAS_URL = value;
            }
        }

        object KEY_DEVELOPER_NAME
        {
            get
            {
                return Self.KEY_DEVELOPER_NAME;
            }
            set
            {
                Self.KEY_DEVELOPER_NAME = value;
            }
        }

        object KEY_DISPLAY_LOCATION
        {
            get
            {
                return Self.KEY_DISPLAY_LOCATION;
            }
            set
            {
                Self.KEY_DISPLAY_LOCATION = value;
            }
        }

        object KEY_LOCATION_URL
        {
            get
            {
                return Self.KEY_LOCATION_URL;
            }
            set
            {
                Self.KEY_LOCATION_URL = value;
            }
        }

        object KEY_NAME
        {
            get
            {
                return Self.KEY_NAME;
            }
            set
            {
                Self.KEY_NAME = value;
            }
        }

        object KEY_NAMESPACE
        {
            get
            {
                return Self.KEY_NAMESPACE;
            }
            set
            {
                Self.KEY_NAMESPACE = value;
            }
        }

        object KEY_SUB_LOCATION
        {
            get
            {
                return Self.KEY_SUB_LOCATION;
            }
            set
            {
                Self.KEY_SUB_LOCATION = value;
            }
        }

        object KEY_VERSION
        {
            get
            {
                return Self.KEY_VERSION;
            }
            set
            {
                Self.KEY_VERSION = value;
            }
        }

        public Test()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static RenderContext mockRenderContext(Map<string, string> appContextTestValues, Map<string, string> envContextTestValues)
        {
            return Implementation.mockRenderContext(appContextTestValues, envContextTestValues);
        }

        public static void testCanvasLifecycle(CanvasLifecycleHandler handler, RenderContext mockRenderContext)
        {
            Implementation.testCanvasLifecycle(handler, mockRenderContext);
        }
    }
}
