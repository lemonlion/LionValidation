using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DobOlderThan21Tests : TestsBase
    {
        [TestMethod]
        public void DobOlderThan21Test1()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-21).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DobOlderThan21Test2()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-21).AddDays(-1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DobOlderThan21Test3()
        {
            FirstField.SendKeys(DateTime.Now.AddYears(-21).AddDays(1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DobOlderThan21Test4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DobOlderThan21Test5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DobOlderThan21Tests_NoJS : DobOlderThan21Tests
    { }
}