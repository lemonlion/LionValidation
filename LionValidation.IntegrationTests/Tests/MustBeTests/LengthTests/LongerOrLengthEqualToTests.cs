using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LongerOrLengthEqualToTests : TestsBase
    {
        [TestMethod]
        public void LongerOrLengthEqualToTest1()
        {
            FirstField.SendKeys("01234");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LongerOrLengthEqualToTest2()
        {
            FirstField.SendKeys("0123");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LongerOrLengthEqualToTest3()
        {
            FirstField.SendKeys("012345");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LongerOrLengthEqualToTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LongerOrLengthEqualToTests_NoJS : LongerOrLengthEqualToTests
    {}
}