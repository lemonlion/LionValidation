using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LengthEqualToAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
            ThirdField.SendKeys("TestDataLong");
        }

        [TestMethod]
        public void LengthEqualToAnyFieldTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LengthEqualToAnyFieldTest2()
        {
            FirstField.SendKeys("BestDataLong");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }


        [TestMethod]
        public void LengthEqualToAnyFieldTest3()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToAnyFieldTest4()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LengthEqualToAnyFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LengthEqualToAnyFieldTests_NoJS : LengthEqualToAnyFieldTests
    {}
}