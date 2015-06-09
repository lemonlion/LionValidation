using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class PositiveOrZeroIntTests : TestsBase
    {
        [TestMethod]
        public void PositiveOrZeroIntTest1()
        {
            IntField.SendKeys("1");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void PositiveOrZeroIntTest2()
        {
            IntField.SendKeys("0");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void PositiveOrZeroIntTest3()
        {
            IntField.SendKeys("-1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntTest4()
        {
            IntField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntTest5()
        {
            IntField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntTest6()
        {
            IntField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntTest7()
        {
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }
    }

    [TestClass]
    public class PositiveOrZeroIntTests_NoJS : PositiveOrZeroIntTests
    { }
}