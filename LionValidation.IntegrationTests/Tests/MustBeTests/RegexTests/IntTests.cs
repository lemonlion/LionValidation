using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class IntTests : TestsBase
    {
        [TestMethod]
        public void IntTest1()
        {
            IntField.SendKeys("1");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void IntTest2()
        {
            IntField.SendKeys("0");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void IntTest3()
        {
            IntField.SendKeys("-1");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void IntTest4()
        {
            IntField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void IntTest5()
        {
            IntField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void IntTest6()
        {
            IntField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }

        [TestMethod]
        public void IntTest7()
        {
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }
    }

    [TestClass]
    public class IntTests_NoJS : IntTests
    { }
}