using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class OlderThanRelativeDateStringTests : TestsBase
    {
        private DateTime Date69Years11MonthsFromNow = DateTime.Now.AddYears(69).AddMonths(11);
        
        [TestMethod]
        public void OlderThanRelativeDateStringTest1()
        {
            FirstField.SendKeys(Date69Years11MonthsFromNow.AddDays(-1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanRelativeDateStringTest2()
        {
            FirstField.SendKeys(Date69Years11MonthsFromNow.ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanRelativeDateStringTest3()
        {
            FirstField.SendKeys(Date69Years11MonthsFromNow.AddDays(1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanRelativeDateStringTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class OlderThanRelativeDateStringTests_NoJS : OlderThanRelativeDateStringTests
    {}
}