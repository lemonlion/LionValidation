using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class EqualToTests : TestsBase
    {
        [TestMethod]
        public void EqualToTest1()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void EqualToTest2()
        {
            FirstField.SendKeys(" TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void EqualToTest3()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void EqualToTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class EqualToTests_NoJS : EqualToTests
    {}
}