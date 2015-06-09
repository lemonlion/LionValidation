using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DoesntContainAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("StringToContain");
            ThirdField.SendKeys("SecondToContain");
        }

        [TestMethod]
        public void DoesntContainAnyFieldTest1()
        {
            FirstField.SendKeys("dStringToContaindSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DoesntContainAnyFieldTest2()
        {
            FirstField.SendKeys("dStringToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainAnyFieldTest3()
        {
            FirstField.SendKeys("dSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainAnyFieldTest4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainAnyFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DoesntContainAnyFieldTests_NoJS : DoesntContainAnyFieldTests
    {}
}