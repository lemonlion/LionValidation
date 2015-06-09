using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LessThanAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("5");
            ThirdField.SendKeys("10");
        }

        [TestMethod]
        public void LessThanAnyFieldTest1()
        {
            FirstField.SendKeys("10");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanAnyFieldTest2()
        {
            FirstField.SendKeys("9");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanAnyFieldTest3()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanAnyFieldTest4()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanAnyFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LessThanAnyFieldTests_NoJS : LessThanAnyFieldTests
    {}
}