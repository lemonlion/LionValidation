using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class EqualToAnyTests : TestsBase
    {
        [TestMethod]
        public void EqualToAnyTest1()
        {
            FirstField.SendKeys("TestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void EqualToAnyTest2()
        {
            FirstField.SendKeys("TestData2");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void EqualToAnyTest3()
        {
            FirstField.SendKeys(" TestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void EqualToAnyTest4()
        {
            FirstField.SendKeys("0");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void EqualToAnyTestTestData()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class EqualToAnyTests_NoJS : EqualToAnyTests
    {}
}