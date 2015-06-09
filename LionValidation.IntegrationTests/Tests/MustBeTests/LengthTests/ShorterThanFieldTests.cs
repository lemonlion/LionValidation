using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class ShorterThanFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("TestData");
        }

        [TestMethod]
        public void ShorterThanFieldTest1()
        {
            FirstField.SendKeys("BestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }
        
        [TestMethod]
        public void ShorterThanFieldTest2()
        {
            FirstField.SendKeys("BestDat");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void ShorterThanFieldTest3()
        {
            FirstField.SendKeys("BestDatas");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void ShorterThanFieldTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class ShorterThanFieldTests_NoJS : ShorterThanFieldTests
    {}
}