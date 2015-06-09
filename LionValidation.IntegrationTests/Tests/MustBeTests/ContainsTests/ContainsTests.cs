using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ContainsTests : TestsBase
    {
        [TestMethod]
        public void ContainsTest1()
        {
            FirstField.SendKeys("asdStringToContaindad");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ContainsTest2()
        {
            FirstField.SendKeys("Test Data");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ContainsTest3()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ContainsTests_NoJS : ContainsTests
    {}
}