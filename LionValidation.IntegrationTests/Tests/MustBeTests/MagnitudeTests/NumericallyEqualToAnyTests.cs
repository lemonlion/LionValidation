using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NumericallyEqualToAnyTests : TestsBase
    {
        [TestMethod]
        public void NumericallyEqualToAnyTest1()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyTest2()
        {
            FirstField.SendKeys("10");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyTest3()
        {
            FirstField.SendKeys(" 5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyTest4()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void NumericallyEqualToAnyTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class NumericallyEqualToAnyTests_NoJS : NumericallyEqualToAnyTests
    {}
}