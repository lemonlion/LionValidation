using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DateEqualToAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
            ThirdField.SendKeys("10/01/2014");
        }

        [TestMethod]
        public void DateEqualToAnyFieldTest1()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DateEqualToAnyFieldTest2()
        {
            FirstField.SendKeys("10/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DateEqualToAnyFieldTest3()
        {
            FirstField.SendKeys("01/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DateEqualToAnyFieldTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DateEqualToAnyFieldTests_NoJS : DateEqualToAnyFieldTests
    {}
}