using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class MoreRecentThanOrEqualToAnyFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
            ThirdField.SendKeys("10/01/2014");
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToAnyFieldTest1()
        {
            FirstField.SendKeys("06/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToAnyFieldTest2()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToAnyFieldTest3()
        {
            FirstField.SendKeys("04/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToAnyFieldTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class MoreRecentThanOrEqualToAnyFieldTests_NoJS : MoreRecentThanOrEqualToAnyFieldTests
    {}
}