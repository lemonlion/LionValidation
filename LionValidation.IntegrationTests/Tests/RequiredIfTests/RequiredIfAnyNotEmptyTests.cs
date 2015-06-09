using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAnyNotEmptyTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAnyNotEmptyTest1()
        {
            SecondField.SendKeys("Test Data");
            ThirdField.SendKeys("Test Data2");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyNotEmptyTest2()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyNotEmptyTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfAnyNotEmptyTests_NoJS : RequiredIfAnyNotEmptyTests
    {}
}