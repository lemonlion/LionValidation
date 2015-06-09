using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfFalseTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfFalseTest1()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfFalseTest2()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfFalseTests_NoJS : RequiredIfFalseTests
    {}
}