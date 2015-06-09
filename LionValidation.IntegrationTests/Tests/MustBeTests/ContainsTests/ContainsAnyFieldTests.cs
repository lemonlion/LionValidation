using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ContainsAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("StringToContain");
            ThirdField.SendKeys("SecondToContain");
        }

        [TestMethod]
        public void ContainsAnyFieldTest1()
        {
            FirstField.SendKeys("dStringToContaindSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ContainsAnyFieldTest2()
        {
            FirstField.SendKeys("dStringToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ContainsAnyFieldTest3()
        {
            FirstField.SendKeys("dSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ContainsAnyFieldTest4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ContainsAnyFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ContainsAnyFieldTests_NoJS : ContainsAnyFieldTests
    {}
}