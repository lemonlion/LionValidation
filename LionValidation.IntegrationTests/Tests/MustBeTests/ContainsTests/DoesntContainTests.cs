using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class DoesntContainTests : TestsBase
    {
        [TestMethod]
        public void DoesntContainTests1()
        {
            FirstField.SendKeys("asdStringToContaindad");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void DoesntContainTests2()
        {
            FirstField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void DoesntContainTests3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class DoesntContainTests_NoJS : DoesntContainTests
    {}
}