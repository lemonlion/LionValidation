using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DateNotEqualToFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
        }

        [TestMethod]
        public void DateNotEqualToFieldTest1()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DateNotEqualToFieldTest4()
        {
            FirstField.SendKeys("01/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DateNotEqualToFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DateNotEqualToFieldTests_NoJS : DateNotEqualToFieldTests
    {}
}