using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfRegexMatchTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfRegexMatchTest1()
        {
            SecondField.SendKeys("M25 0HF");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfRegexMatchTest2()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfRegexMatchTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfRegexMatchTests_NoJS : RequiredIfRegexMatchTests
    {}
}