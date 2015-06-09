using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NegativeIntTests : TestsBase
    {
        [TestMethod]
        public void NegativeIntTest1()
        {
            IntField.SendKeys("1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntTest2()
        {
            IntField.SendKeys("0");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntTest3()
        {
            IntField.SendKeys("-1");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void NegativeIntTest4()
        {
            IntField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntTest5()
        {
            IntField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntTest6()
        {
            IntField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void NegativeIntTest7()
        {
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }
    }

    [TestClass]
    public class NegativeIntTests_NoJS : NegativeIntTests
    { }
}