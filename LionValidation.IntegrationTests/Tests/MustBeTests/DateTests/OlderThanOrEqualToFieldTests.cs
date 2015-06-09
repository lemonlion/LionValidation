using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class OlderThanOrEqualToFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
        }

        [TestMethod]
        public void OlderThanOrEqualToFieldTest1()
        {
            FirstField.SendKeys("06/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanOrEqualToFieldTest2()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanOrEqualToFieldTest3()
        {
            FirstField.SendKeys("04/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanOrEqualToFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class OlderThanOrEqualToFieldTests_NoJS : OlderThanOrEqualToFieldTests
    {}
}