using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LessThanOrEqualToFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("5");
        }

        [TestMethod]
        public void LessThanOrEqualToFieldTest1()
        {
            FirstField.SendKeys("6");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LessThanOrEqualToFieldTest2()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanOrEqualToFieldTest3()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LessThanOrEqualToFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LessThanOrEqualToFieldTests_NoJS : LessThanOrEqualToFieldTests
    {}
}