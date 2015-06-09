using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAnyEmptyTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAnyEmptyTest1()
        {
            SecondField.SendKeys("Test Data");
            ThirdField.SendKeys("Test Data2");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAnyEmptyTest2()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyEmptyTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfAnyEmptyTests_NoJS : RequiredIfAnyEmptyTests
    {}
}