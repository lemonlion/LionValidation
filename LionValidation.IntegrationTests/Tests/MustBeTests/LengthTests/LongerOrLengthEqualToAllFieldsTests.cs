using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LongerOrLengthEqualToAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
            ThirdField.SendKeys("TestDataLong");
        }

        [TestMethod]
        public void LongerOrLengthEqualToAllFieldsTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LongerOrLengthEqualToAllFieldsTest2()
        {
            FirstField.SendKeys("BestDataLong");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }


        [TestMethod]
        public void LongerOrLengthEqualToAllFieldsTest3()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LongerOrLengthEqualToAllFieldsTest4()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LongerOrLengthEqualToAllFieldsTest5()
        {
            FirstField.SendKeys("BestDataLongs");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LongerOrLengthEqualToAllFieldsTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LongerOrLengthEqualToAllFieldsTests_NoJS : LongerOrLengthEqualToAllFieldsTests
    {}
}