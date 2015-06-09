using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DoesntContainAnyTests : TestsBase
    {
        [TestMethod]
        public void DoesntContainAnyTest1()
        {
            FirstField.SendKeys("dStringToContaindSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DoesntContainAnyTest2()
        {
            FirstField.SendKeys("dStringToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainAnyTest3()
        {
            FirstField.SendKeys("dSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainAnyTest4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainAnyTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DoesntContainAnyTests_NoJS : DoesntContainAnyTests
    {}
}