using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DateEqualToAnyTests : TestsBase
    {
        [TestMethod]
        public void DateEqualToAnyTest1()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DateEqualToAnyTest2()
        {
            FirstField.SendKeys("10/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DateEqualToAnyTest4()
        {
            FirstField.SendKeys("01/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DateEqualToAnyTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DateEqualToAnyTests_NoJS : DateEqualToAnyTests
    {}
}