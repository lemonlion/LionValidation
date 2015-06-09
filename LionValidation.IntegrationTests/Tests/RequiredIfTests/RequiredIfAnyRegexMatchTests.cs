using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfAnyRegexMatchTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfAnyRegexMatchTest1()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("M25 0HB");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexMatchTest2()
        {
            SecondField.SendKeys("M25 0HF");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexMatchTest3()
        {
            SecondField.SendKeys("M25 0HF");
            ThirdField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexMatchTest4()
        {
            SecondField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void RequiredIfAnyRegexMatchTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfAnyRegexMatchTests_NoJS : RequiredIfAnyRegexMatchTests
    {}
}