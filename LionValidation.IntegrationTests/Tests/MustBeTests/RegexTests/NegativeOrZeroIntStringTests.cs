using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NegativeOrZeroIntStringTests : TestsBase
    {
        [TestMethod]
        public void NegativeOrZeroIntStringTest1()
        {
            FirstField.SendKeys("1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntStringTest2()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NegativeOrZeroIntStringTest3()
        {
            FirstField.SendKeys("-1");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NegativeOrZeroIntStringTest4()
        {
            FirstField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntStringTest5()
        {
            FirstField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntStringTest6()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntStringTest7()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class NegativeOrZeroIntStringTests_NoJS : NegativeOrZeroIntStringTests
    { }
}