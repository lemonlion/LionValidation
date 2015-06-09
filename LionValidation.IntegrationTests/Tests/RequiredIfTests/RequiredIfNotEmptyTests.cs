using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfNotEmptyTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfEmptyTest1()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfEmptyTest2()
        {
            SecondField.Clear();
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfNotEmptyTests_NoJS : RequiredIfNotEmptyTests
    {}
}