using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAllNotEmptyTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAllNotEmptyTest1()
        {
            SecondField.SendKeys("Test Data");
            ThirdField.SendKeys("Test Data2");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAllNotEmptyTest2()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllNotEmptyTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfAllNotEmptyTests_NoJS : RequiredIfAllNotEmptyTests
    {}
}