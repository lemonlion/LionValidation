using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DobOlderThan18Tests : TestsBase
    {
        [TestMethod]
        public void DobOlderThan18Test1()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-18).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DobOlderThan18Test2()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-18).AddDays(-1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DobOlderThan18Test3()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-18).AddDays(1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DobOlderThan18Test4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DobOlderThan18Test5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DobOlderThan18Tests_NoJS : DobOlderThan18Tests
    { }
}