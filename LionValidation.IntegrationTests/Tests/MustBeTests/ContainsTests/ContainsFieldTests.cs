using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ContainsFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("StringToContain");
        }

        [TestMethod]
        public void ContainsFieldTest1()
        {
            FirstField.SendKeys("asdStringToContaindad");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ContainsFieldTest2()
        {
            FirstField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ContainsFieldTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ContainsFieldTests_NoJS : ContainsFieldTests
    {}
}