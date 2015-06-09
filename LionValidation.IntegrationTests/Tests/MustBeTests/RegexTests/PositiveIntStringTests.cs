using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class PositiveIntStringTests : TestsBase
    {
        [TestMethod]
        public void PositiveIntStringTest1()
        {
            FirstField.SendKeys("1");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void PositiveIntStringTest2()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntStringTest3()
        {
            FirstField.SendKeys("-1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntStringTest4()
        {
            FirstField.SendKeys("1.0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntStringTest5()
        {
            FirstField.SendKeys("1.1");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntStringTest6()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void PositiveIntStringTest7()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class PositiveIntStringTests_NoJS : PositiveIntStringTests
    { }
}