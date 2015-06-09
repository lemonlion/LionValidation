using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ShorterThanAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
            ThirdField.SendKeys("TestDataLong");
        }

        [TestMethod]
        public void ShorterThanAllFieldsTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ShorterThanAllFieldsTest2()
        {
            FirstField.SendKeys("BestDataLong");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }


        [TestMethod]
        public void ShorterThanAllFieldsTest3()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterThanAllFieldsTest4()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ShorterThanAllFieldsTest5()
        {
            FirstField.SendKeys("BestDataLongs");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ShorterThanAllFieldsTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ShorterThanAllFieldsTests_NoJS : ShorterThanAllFieldsTests
    {}
}