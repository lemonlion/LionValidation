using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LessThanOrEqualToAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("5");
            ThirdField.SendKeys("10");
        }

        [TestMethod]
        public void LessThanOrEqualToAllFieldsTest1()
        {
            FirstField.SendKeys("11");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanOrEqualToAllFieldsTest2()
        {
            FirstField.SendKeys("10");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanOrEqualToAllFieldsTest3()
        {
            FirstField.SendKeys("9");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanOrEqualToAllFieldsTest4()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanOrEqualToAllFieldsTest5()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanOrEqualToAllFieldsTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LessThanOrEqualToAllFieldsTests_NoJS : LessThanOrEqualToAllFieldsTests
    {}
}