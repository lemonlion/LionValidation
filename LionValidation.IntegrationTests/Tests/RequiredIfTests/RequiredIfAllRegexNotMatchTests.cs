using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAllRegexNotMatchTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAllRegexNotMatchTest1()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("M25 0HB");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllRegexNotMatchTest2()
        {
            SecondField.SendKeys("M25 0HF");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllRegexNotMatchTest3()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAllRegexNotMatchTest4()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAllRegexNotMatchTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfAllRegexNotMatchTests_NoJS : RequiredIfAllRegexNotMatchTests
    {}
}