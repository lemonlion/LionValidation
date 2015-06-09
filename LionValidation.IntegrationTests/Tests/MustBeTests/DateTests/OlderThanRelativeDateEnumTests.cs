using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class OlderThanRelativeDateEnumTests : TestsBase
    {
        private DateTime Date48DaysFromNow = DateTime.Now.AddDays(48);
        
        [TestMethod]
        public void OlderThanRelativeDateEnumTest1()
        {
            FirstField.SendKeys(Date48DaysFromNow.AddDays(-1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanRelativeDateEnumTest2()
        {
            FirstField.SendKeys(Date48DaysFromNow.ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanRelativeDateEnumTest3()
        {
            FirstField.SendKeys(Date48DaysFromNow.AddDays(1).ToShortDateString());
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanRelativeDateEnumTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class OlderThanRelativeDateEnumTests_NoJS : OlderThanRelativeDateEnumTests
    {}
}