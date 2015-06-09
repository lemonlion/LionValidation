using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DoesntContainAllTests : TestsBase
    {
        [TestMethod]
        public void DoesntContainAllTest1()
        {
            FirstField.SendKeys("dStringToContaindSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DoesntContainAllTest2()
        {
            FirstField.SendKeys("dStringToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DoesntContainAllTest3()
        {
            FirstField.SendKeys("dSecondToContaind");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DoesntContainAllTest4()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainAllTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DoesntContainAllTests_NoJS : DoesntContainAllTests
    {}
}