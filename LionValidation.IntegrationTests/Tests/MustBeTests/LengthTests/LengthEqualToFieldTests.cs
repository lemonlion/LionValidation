using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LengthEqualToFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
        }

        [TestMethod]
        public void LengthEqualToFieldTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LengthEqualToFieldTest2()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToFieldTest3()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToFieldTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LengthEqualToFieldTests_NoJS : LengthEqualToFieldTests
    {}
}