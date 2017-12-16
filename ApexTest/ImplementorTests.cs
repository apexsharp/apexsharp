using System;
using System.Dynamic;
using Apex.ApexSharp.Implementation;
using NUnit.Framework;

namespace ApexTest
{
    [TestFixture]
    public class ImplementorTests
    {
        [Test]
        public void ImplementorForTheUnknownTypeReturnsStubImplementation()
        {
            var impl = Implementor.GetImplementation(typeof(string));
            Assert.IsInstanceOf<StubImplementation>(impl);

            try
            {
                impl.IsNullOrWhiteSpace(string.Empty);
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("System.String.IsNullOrWhiteSpace(String)", ex.Message);
            }
        }

        public class SomeApiClass
        {
            // infrastructure
            public SomeApiClass(dynamic self)
            {
                Self = self;
            }

            private dynamic Self { get; }

            private static dynamic Implementation
            {
                get { return Implementor.GetImplementation<SomeApiClass>(); }
            }

            // API
            public static bool isLoading(string x)
            {
                return Implementation.isLoading(x);
            }

            public static int add(int x, int y)
            {
                return Implementation.add(x, y);
            }

            public SomeApiClass(string name, int value)
            {
                Self = Implementation.ctor(name, value);
            }

            public string Name { get { return Self.Name; } }

            public int Value { get { return Self.Value; } set { Self.Value = value; } }
        }

        [Test]
        public void ByDefaultApiClassStaticMethodIsNotImplemented()
        {
            try
            {
                var result = SomeApiClass.isLoading("Test");
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("ApexTest.ImplementorTests+SomeApiClass.isLoading(String)", ex.Message);
            }

            try
            {
                var result = SomeApiClass.add(2, 2);
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("ApexTest.ImplementorTests+SomeApiClass.add(Int32, Int32)", ex.Message);
            }

            try
            {
                var result = new SomeApiClass("Name", 123);
            }
            catch (NotImplementedException ex)
            {
                Assert.AreEqual("ApexTest.ImplementorTests+SomeApiClass.ctor(String, Int32)", ex.Message);
            }
        }

        [Test]
        public void ImplementedStaticMethodReturnsAValue()
        {
            try
            {
                // mock two static methods without creating a class
                dynamic stub = new ExpandoObject();
                stub.isLoading = new Func<string, bool>(s => s == "Test");
                stub.add = new Func<int, int, int>((x, y) => x + y);

                // register the implementation
                Implementor.SetImplementation(typeof(SomeApiClass), stub);

                // check that the methods now don't throw exceptions
                Assert.DoesNotThrow(() =>
                {
                    var a = SomeApiClass.isLoading("Sample");
                    Assert.IsFalse(a);

                    var b = SomeApiClass.isLoading("Test");
                    Assert.IsTrue(b);

                    var z = SomeApiClass.add(353, 181);
                    Assert.AreEqual(534, z);
                });
            }
            finally
            {
                // reset to the default implementations
                Implementor.ResetToDefault();

                // make sure that now the methods throw exceptions
                Assert.Throws<NotImplementedException>(() => SomeApiClass.add(123, 321));
            }
        }

        public class SomeApiClassImplementation
        {
            public class SomeApiClassInstance
            {
                public SomeApiClassInstance(string name, int value)
                {
                    Name = name;
                    Value = value;
                }

                public string Name { get; }
                public int Value { get; set; }
            }

            // API
            public bool isLoading(string x)
            {
                return !string.IsNullOrWhiteSpace(x);
            }

            public int add(int x, int y)
            {
                if (x < 200)
                {
                    return x + y;
                }

                using (Implementor.UseDefaultImplementation<SomeApiClass>())
                {
                    return SomeApiClass.add(x, y);
                }
            }

            public SomeApiClass ctor(string name, int value)
            {
                dynamic instance = new SomeApiClassInstance(name, value);
                return new SomeApiClass(instance);
            }
        }

        [Test]
        public void ImplementedConstructorReturnsAnInstance()
        {
            try
            {
                // register the implementation
                Implementor.SetImplementation<SomeApiClass>(new SomeApiClassImplementation());

                // check that the methods now don't throw exceptions
                Assert.DoesNotThrow(() =>
                {
                    var a = SomeApiClass.isLoading(string.Empty);
                    Assert.IsFalse(a);

                    var b = SomeApiClass.isLoading("string.NotEmpty");
                    Assert.IsTrue(b);

                    var z = SomeApiClass.add(111, 222);
                    Assert.AreEqual(333, z);

                    // x > 200 invokes the default implementation
                    try
                    {
                        SomeApiClass.add(222, 111);
                    }
                    catch (NotImplementedException ex)
                    {
                        Assert.AreEqual("ApexTest.ImplementorTests+SomeApiClass.add(Int32, Int32)", ex.Message);
                    }

                    var c = new SomeApiClass("Name", 123);
                    Assert.AreEqual("Name", c.Name);
                    Assert.AreEqual(123, c.Value);

                    c.Value = 321;
                    Assert.AreEqual(321, c.Value);
                });
            }
            finally
            {
                // reset to the default implementations
                Implementor.ResetToDefault();

                // make sure that now the constructor throws the exception
                Assert.Throws<NotImplementedException>(() => new SomeApiClass("Name", 123));
            }
        }
    }
}
