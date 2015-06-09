using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfNotTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfNotTest1()
        {
            SecondField.SendKeys("ForbiddenTestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfNotTest2()
        {
            SecondField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfNotTests_NoJS : RequiredIfNotTests
    {}
}