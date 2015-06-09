using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAnyTrueTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAnyTrueTest1()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAnyTrueTest2()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyTrueTest3()
        {
            BooleanOneField.Click();
            BooleanTwoField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfAnyTrueTests_NoJS : RequiredIfAnyTrueTests
    {}
}