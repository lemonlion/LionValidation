using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class GreaterThanFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("5");
        }

        [TestMethod]
        public void GreaterThanFieldTest1()
        {
            FirstField.SendKeys("6");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void GreaterThanFieldTest2()
        {
            FirstField.SendKeys("5");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void GreaterThanFieldTest3()
        {
            FirstField.SendKeys("4");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void GreaterThanFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class GreaterThanFieldTests_NoJS : GreaterThanFieldTests
    {}
}