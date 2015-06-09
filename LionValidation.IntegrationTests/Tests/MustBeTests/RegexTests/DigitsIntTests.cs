using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DigitsIntTests : TestsBase
    {
        [TestMethod]
        public void DigitsIntTest1()
        {
            IntField.SendKeys("123");
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }

        [TestMethod]
        public void DigitsIntTest2()
        {
            IntField.SendKeys("-123");
            Validate();
            Assert.IsTrue(IntField.IsInvalid());
        }
        
        [TestMethod]
        public void DigitsIntTest3()
        {
            Validate();
            Assert.IsTrue(IntField.IsValid());
        }
    }

    [TestClass]
    public class DigitsIntTests_NoJS : DigitsIntTests
    { }
}