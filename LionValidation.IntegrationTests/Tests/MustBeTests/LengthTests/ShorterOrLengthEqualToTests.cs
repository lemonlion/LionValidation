using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ShorterOrLengthEqualToTests : TestsBase
    {
        [TestMethod]
        public void ShorterOrLengthEqualToTest1()
        {
            FirstField.SendKeys("01234");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterOrLengthEqualToTest2()
        {
            FirstField.SendKeys("0123");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterOrLengthEqualToTest3()
        {
            FirstField.SendKeys("012345");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ShorterOrLengthEqualToTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ShorterOrLengthEqualToTests_NoJS : ShorterOrLengthEqualToTests
    {}
}