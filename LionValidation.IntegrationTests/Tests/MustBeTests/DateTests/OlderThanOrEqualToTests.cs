using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class OlderThanOrEqualToTests : TestsBase
    {
        [TestMethod]
        public void OlderThanOrEqualToTest1()
        {
            FirstField.SendKeys("06/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanOrEqualToTest2()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanOrEqualToTest3()
        {
            FirstField.SendKeys("04/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanOrEqualToTest4()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class OlderThanOrEqualToTests_NoJS : OlderThanOrEqualToTests
    {}
}