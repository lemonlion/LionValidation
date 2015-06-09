using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class OlderThanFieldTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
        }

        [TestMethod]
        public void OlderThanFieldTest1()
        {
            FirstField.SendKeys("06/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanFieldTest2()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanFieldTest3()
        {
            FirstField.SendKeys("04/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanFieldTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class OlderThanFieldTests_NoJS : OlderThanFieldTests
    {}
}