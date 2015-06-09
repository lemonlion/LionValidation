using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class LongerThanAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
            ThirdField.SendKeys("TestDataLong");
        }

        [TestMethod]
        public void LongerThanAllFieldsTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LongerThanAllFieldsTest2()
        {
            FirstField.SendKeys("BestDataLong");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }


        [TestMethod]
        public void LongerThanAllFieldsTest3()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LongerThanAllFieldsTest4()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void LongerThanAllFieldsTest5()
        {
            FirstField.SendKeys("BestDataLongs");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void LongerThanAllFieldsTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class LongerThanAllFieldsTests_NoJS : LongerThanAllFieldsTests
    {}
}