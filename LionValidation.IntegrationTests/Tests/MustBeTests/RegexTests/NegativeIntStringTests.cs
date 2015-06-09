using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NegativeIntStringTests : TestsBase
    {
        [TestMethod]
        public void NegativeIntStringTest1()
        {
            FirstField.SendKeys("1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntStringTest2()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntStringTest3()
        {
            FirstField.SendKeys("-1");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NegativeIntStringTest4()
        {
            FirstField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntStringTest5()
        {
            FirstField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntStringTest6()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntStringTest7()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class NegativeIntStringTests_NoJS : NegativeIntStringTests
    { }
}