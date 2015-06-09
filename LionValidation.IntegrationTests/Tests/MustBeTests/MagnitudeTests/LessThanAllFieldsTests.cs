using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LessThanAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("5");
            ThirdField.SendKeys("10");
        }

        [TestMethod]
        public void LessThanAllFieldsTest1()
        {
            FirstField.SendKeys("10");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanAllFieldsTest2()
        {
            FirstField.SendKeys("9");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanAllFieldsTest3()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanAllFieldsTest4()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanAllFieldsTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LessThanAllFieldsTests_NoJS : LessThanAllFieldsTests
    {}
}