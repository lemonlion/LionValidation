using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class MoreRecentThanOrEqualToFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToFieldTest1()
        {
            FirstField.SendKeys("06/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToFieldTest2()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToFieldTest3()
        {
            FirstField.SendKeys("04/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void MoreRecentThanOrEqualToFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class MoreRecentThanOrEqualToFieldTests_NoJS : MoreRecentThanOrEqualToFieldTests
    {}
}