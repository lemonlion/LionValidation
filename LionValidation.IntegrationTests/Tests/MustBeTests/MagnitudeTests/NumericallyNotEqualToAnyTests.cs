using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class NumericallyNotEqualToAnyTests : TestsBase
    {
        [TestMethod]
        public void NumericallyNotEqualToAnyTest1()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyTest2()
        {
            FirstField.SendKeys("10");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyTest3()
        {
            FirstField.SendKeys(" 5");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyTest4()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void NumericallyNotEqualToAnyTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class NumericallyNotEqualToAnyTests_NoJS : NumericallyNotEqualToAnyTests
    {}
}