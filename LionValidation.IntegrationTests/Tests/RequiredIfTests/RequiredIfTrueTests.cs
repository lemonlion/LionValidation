using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfTrueTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfTrueTest1()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfTrueTest2()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfTrueTests_NoJS : RequiredIfTrueTests
    {}
}