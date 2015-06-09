using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NegativeOrZeroIntTests : TestsBase
    {
        [TestMethod]
        public void NegativeOrZeroIntTest1()
        {
            IntField.SendKeys("1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntTest2()
        {
            IntField.SendKeys("0");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void NegativeOrZeroIntTest3()
        {
            IntField.SendKeys("-1");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void NegativeOrZeroIntTest4()
        {
            IntField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntTest5()
        {
            IntField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntTest6()
        {
            IntField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeOrZeroIntTest7()
        {
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }
    }

    [TestClass]
    public class NegativeOrZeroIntTests_NoJS : NegativeOrZeroIntTests
    { }
}