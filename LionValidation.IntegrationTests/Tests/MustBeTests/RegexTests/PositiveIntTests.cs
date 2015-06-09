using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class PositiveIntTests : TestsBase
    {
        [TestMethod]
        public void PositiveIntTest1()
        {
            IntField.SendKeys("1");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void PositiveIntTest2()
        {
            IntField.SendKeys("0");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntTest3()
        {
            IntField.SendKeys("-1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntTest4()
        {
            IntField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntTest5()
        {
            IntField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntTest6()
        {
            IntField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntTest7()
        {
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }
    }

    [TestClass]
    public class PositiveIntTests_NoJS : PositiveIntTests
    { }
}