using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAnyRegexNotMatchTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAnyRegexNotMatchTest1()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("M25 0HB");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexNotMatchTest2()
        {
            SecondField.SendKeys("M25 0HF");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexNotMatchTest3()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexNotMatchTest4()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexNotMatchTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
    }

    [TestClass]
    public class RequiredIfAnyRegexNotMatchTests_NoJS : RequiredIfAnyRegexNotMatchTests
    {}
}