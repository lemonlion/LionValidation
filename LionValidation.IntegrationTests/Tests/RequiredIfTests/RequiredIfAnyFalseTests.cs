using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAnyFalseTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAnyFalseTest1()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyFalseTest2()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyFalseTest3()
        {
            BooleanOneField.Click();
            BooleanTwoField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfAnyFalseTests_NoJS : RequiredIfAnyFalseTests
    {}
}