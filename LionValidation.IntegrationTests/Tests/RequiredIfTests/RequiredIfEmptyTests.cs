using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfEmptyTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfEmptyTest1()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfEmptyTest2()
        {
            SecondField.Clear();
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfEmptyTests_NoJS : RequiredIfEmptyTests
    {}
}