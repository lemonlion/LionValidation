using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class MoreRecentThanRelativeDateStringTests : TestsBase
    {
        private DateTime Date69Years11MonthsAgo = DateTime.Now.AddYears(-69).AddMonths(-11);
        
        [TestMethod]
        public void MoreRecentThanRelativeDateStringTest1()
        {
            FirstField.SendKeys(Date69Years11MonthsAgo.AddDays(1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void MoreRecentThanRelativeDateStringTest2()
        {
            FirstField.SendKeys(Date69Years11MonthsAgo.ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void MoreRecentThanRelativeDateStringTest3()
        {
            FirstField.SendKeys(Date69Years11MonthsAgo.AddDays(-1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void MoreRecentThanRelativeDateStringTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class MoreRecentThanRelativeDateStringTests_NoJS : MoreRecentThanRelativeDateStringTests
    {}
}