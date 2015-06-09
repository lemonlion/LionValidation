using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NumericallyNotEqualToAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("5");
            ThirdField.SendKeys("10");
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyFieldTest1()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyFieldTest2()
        {
            FirstField.SendKeys("10");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyFieldTest3()
        {
            FirstField.SendKeys(" 5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyFieldTest4()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyFieldTest5()
        {
            ThirdField.Clear();
            ThirdField.SendKeys("5");
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyFieldTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class NumericallyNotEqualToAnyFieldTests_NoJS : NumericallyNotEqualToAnyFieldTests
    {}
}