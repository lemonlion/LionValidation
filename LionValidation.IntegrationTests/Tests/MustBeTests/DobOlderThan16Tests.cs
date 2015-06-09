using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DobOlderThan16Tests : TestsBase
    {
        [TestMethod]
        public void DobOlderThan16Test1()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-16).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DobOlderThan16Test2()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-16).AddDays(-1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DobOlderThan16Test3()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-16).AddDays(1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DobOlderThan16Test4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DobOlderThan16Test5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DobOlderThan16Tests_NoJS : DobOlderThan16Tests
    { }
}