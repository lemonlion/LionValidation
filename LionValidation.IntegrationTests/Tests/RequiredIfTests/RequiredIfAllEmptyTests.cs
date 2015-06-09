using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAllEmptyTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAllEmptyTest1()
        {
            SecondField.SendKeys("Test Data");
            ThirdField.SendKeys("Test Data2");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllEmptyTest2()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllEmptyTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfAllEmptyTests_NoJS : RequiredIfAllEmptyTests
    {}
}