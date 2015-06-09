using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class MoreRecentThanRelativeDateEnumTests : TestsBase
    {
        private DateTime Date48DaysAgo = DateTime.Now.AddDays(-48);
        
        [TestMethod]
        public void MoreRecentThanRelativeDateEnumTest1()
        {
            FirstField.SendKeys(Date48DaysAgo.AddDays(1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void MoreRecentThanRelativeDateEnumTest2()
        {
            FirstField.SendKeys(Date48DaysAgo.ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void MoreRecentThanRelativeDateEnumTest3()
        {
            FirstField.SendKeys(Date48DaysAgo.AddDays(-1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void MoreRecentThanRelativeDateEnumTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class MoreRecentThanRelativeDateEnumTests_NoJS : MoreRecentThanRelativeDateEnumTests
    {}
}