using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ContainsAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("StringToContain");
            ThirdField.SendKeys("SecondToContain");
        }

        [TestMethod]
        public void ContainsAllFieldsTest1()
        {
            FirstField.SendKeys("dStringToContaindSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ContainsAllFieldsTest2()
        {
            FirstField.SendKeys("dStringToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ContainsAllFieldsTest3()
        {
            FirstField.SendKeys("dSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ContainsAllFieldsTest4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ContainsAllFieldsTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ContainsAllFieldsTests_NoJS : ContainsAllFieldsTests
    {}
}