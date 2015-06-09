using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class PositiveOrZeroIntStringTests : TestsBase
    {
        [TestMethod]
        public void PositiveOrZeroIntStringTest1()
        {
            FirstField.SendKeys("1");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void PositiveOrZeroIntStringTest2()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void PositiveOrZeroIntStringTest3()
        {
            FirstField.SendKeys("-1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntStringTest4()
        {
            FirstField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntStringTest5()
        {
            FirstField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntStringTest6()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveOrZeroIntStringTest7()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class PositiveOrZeroIntStringTests_NoJS : PositiveOrZeroIntStringTests
    { }
}