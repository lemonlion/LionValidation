using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class OlderThanAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
            ThirdField.SendKeys("10/01/2014");
        }

        [TestMethod]
        public void OlderThanAllFieldsTest1()
        {
            FirstField.SendKeys("10/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanAllFieldsTest2()
        {
            FirstField.SendKeys("09/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanAllFieldsTest3()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanAllFieldsTest4()
        {
            FirstField.SendKeys("04/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanAllFieldsTest5()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class OlderThanAllFieldsTests_NoJS : OlderThanAllFieldsTests
    {}
}