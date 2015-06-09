using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DigitsStringTests : TestsBase
    {
        [TestMethod]
        public void DigitsStringTest1()
        {
            FirstField.SendKeys("0123");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DigitsStringTest2()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DigitsStringTest3()
        {
            FirstField.SendKeys("0123TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DigitsStringTest4()
        {
            FirstField.SendKeys(" 123");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DigitsStringTest5()
        {
            FirstField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DigitsStringTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DigitsStringTests_NoJS : DigitsStringTests
    { }
}