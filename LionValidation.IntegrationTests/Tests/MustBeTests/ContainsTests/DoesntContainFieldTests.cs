using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DoesntContainFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("StringToContain");
        }

        [TestMethod]
        public void DoesntContainFieldTests1()
        {
            FirstField.SendKeys("asdStringToContaindad");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DoesntContainFieldTests2()
        {
            FirstField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainFieldTests3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DoesntContainFieldTests_NoJS : DoesntContainFieldTests
    {}
}