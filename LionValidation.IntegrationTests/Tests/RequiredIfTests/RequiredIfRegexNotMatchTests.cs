using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfRegexNotMatchTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfRegexNotMatchTest1()
        {
            SecondField.SendKeys("M25 0HF");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfRegexNotMatchTest2()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfRegexNotMatchTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfRegexNotMatchTests_NoJS : RequiredIfRegexNotMatchTests
    {}
}