using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class IntStringTests : TestsBase
    {
        [TestMethod]
        public void IntStringTest1()
        {
            FirstField.SendKeys("1");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void IntStringTest2()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void IntStringTest3()
        {
            FirstField.SendKeys("-1");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void IntStringTest4()
        {
            FirstField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void IntStringTest5()
        {
            FirstField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void IntStringTest6()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void IntStringTest7()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class IntStringTests_NoJS : IntStringTests
    { }
}