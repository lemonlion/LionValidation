using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ShorterOrLengthEqualToAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
            ThirdField.SendKeys("TestDataLong");
        }

        [TestMethod]
        public void ShorterOrLengthEqualToAnyFieldTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterOrLengthEqualToAnyFieldTest2()
        {
            FirstField.SendKeys("BestDataLong");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }


        [TestMethod]
        public void ShorterOrLengthEqualToAnyFieldTest3()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterOrLengthEqualToAnyFieldTest4()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterOrLengthEqualToAnyFieldTest5()
        {
            FirstField.SendKeys("BestDataLongs");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ShorterOrLengthEqualToAnyFieldTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ShorterOrLengthEqualToAnyFieldTests_NoJS : ShorterOrLengthEqualToAnyFieldTests
    {}
}