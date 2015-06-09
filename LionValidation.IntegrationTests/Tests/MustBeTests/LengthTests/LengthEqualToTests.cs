using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LengthEqualToTests : TestsBase
    {
        [TestMethod]
        public void LengthEqualToTest1()
        {
            FirstField.SendKeys("01234");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LengthEqualToTest2()
        {
            FirstField.SendKeys("0123");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToTest3()
        {
            FirstField.SendKeys("012345");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LengthEqualToTests_NoJS : LengthEqualToTests
    {}
}