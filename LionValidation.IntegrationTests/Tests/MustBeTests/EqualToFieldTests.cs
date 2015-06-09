using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class EqualToFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
        }

        [TestMethod]
        public void EqualToFieldTest1()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void EqualToFieldTest3()
        {
            FirstField.SendKeys(" TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void EqualToFieldTest4()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void EqualToFieldTestTestData()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class EqualToFieldTests_NoJS : EqualToFieldTests
    {}
}