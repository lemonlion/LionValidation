using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAllTrueTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAllTrueTest1()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllTrueTest2()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllTrueTest3()
        {
            BooleanOneField.Click();
            BooleanTwoField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfAllTrueTests_NoJS : RequiredIfAllTrueTests
    {}
}