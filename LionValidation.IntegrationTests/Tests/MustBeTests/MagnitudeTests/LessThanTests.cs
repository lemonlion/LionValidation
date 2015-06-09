using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LessThanTests : TestsBase
    {
        [TestMethod]
        public void LessThanTest1()
        {
            FirstField.SendKeys("6");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanTest2()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanTest3()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LessThanTests_NoJS : LessThanTests
    {}
}