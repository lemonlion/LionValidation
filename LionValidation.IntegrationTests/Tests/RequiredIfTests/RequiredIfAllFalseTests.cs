using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAllFalseTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAllFalseTest1()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAllFalseTest2()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllFalseTest3()
        {
            BooleanOneField.Click();
            BooleanTwoField.Click();
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfAllFalseTests_NoJS : RequiredIfAllFalseTests
    {}
}