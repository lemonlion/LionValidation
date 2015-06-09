using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NumericallyEqualToAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("5");
            ThirdField.SendKeys("10");
        }

        [TestMethod]
        public void NumericallyEqualToAnyFieldTest1()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyFieldTest2()
        {
            FirstField.SendKeys("10");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyFieldTest3()
        {
            FirstField.SendKeys(" 5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyFieldTest4()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class NumericallyEqualToAnyFieldTests_NoJS : NumericallyEqualToAnyFieldTests
    {}
}