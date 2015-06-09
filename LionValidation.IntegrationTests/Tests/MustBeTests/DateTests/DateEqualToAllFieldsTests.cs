using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DateEqualToAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
            ThirdField.SendKeys("05/01/2014");
        }

        [TestMethod]
        public void DateEqualToAllFieldsTest1()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
        
        [TestMethod]
        public void DateEqualToAllFieldsTest2()
        {
            ThirdField.Clear();
            ThirdField.SendKeys("10/01/2014");
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DateEqualToAllFieldsTest3()
        {
            FirstField.SendKeys("01/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DateEqualToAllFieldsTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DateEqualToAllFieldsTests_NoJS : DateEqualToAllFieldsTests
    {}
}