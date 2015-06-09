using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAllRegexMatchTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAllRegexMatchTest1()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("M25 0HB");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAllRegexMatchTest2()
        {
            SecondField.SendKeys("M25 0HF");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllRegexMatchTest3()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllRegexMatchTest4()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllRegexMatchTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfAllRegexMatchTests_NoJS : RequiredIfAllRegexMatchTests
    {}
}