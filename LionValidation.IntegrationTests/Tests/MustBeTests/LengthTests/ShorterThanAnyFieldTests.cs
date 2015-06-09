using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ShorterThanAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
            ThirdField.SendKeys("TestDataLong");
        }

        [TestMethod]
        public void ShorterThanAnyFieldTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterThanAnyFieldTest2()
        {
            FirstField.SendKeys("BestDataLong");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
        
        [TestMethod]
        public void ShorterThanAnyFieldTest3()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterThanAnyFieldTest4()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterThanAnyFieldTest5()
        {
            FirstField.SendKeys("BestDataLongs");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ShorterThanAnyFieldTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ShorterThanAnyFieldTests_NoJS : ShorterThanAnyFieldTests
    {}
}