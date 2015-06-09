using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LengthEqualToAnyTests : TestsBase
    {
        [TestMethod]
        public void LengthEqualToAnyTest1()
        {
            FirstField.SendKeys("01234");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LengthEqualToAnyTest2()
        {
            FirstField.SendKeys("0123456789");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LengthEqualToAnyTest3()
        {
            FirstField.SendKeys("012345678");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
        
        [TestMethod]
        public void LengthEqualToAnyTest4()
        {
            FirstField.SendKeys("01234567890");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToAnyTest5()
        {
            FirstField.SendKeys("0123");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToAnyTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LengthEqualToAnyTests_NoJS : LengthEqualToAnyTests
    {}
}