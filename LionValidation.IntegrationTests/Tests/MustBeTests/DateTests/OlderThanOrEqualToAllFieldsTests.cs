using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class OlderThanOrEqualToAllFieldsTests : TestsBase
    {
        protected override void LocalInitialise()
        {
            SecondField.SendKeys("05/01/2014");
            ThirdField.SendKeys("10/01/2014");
        }

        [TestMethod]
        public void OlderThanOrEqualToAllFieldsTest1()
        {
            FirstField.SendKeys("11/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanOrEqualToAllFieldsTest2()
        {
            FirstField.SendKeys("10/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanOrEqualToAllFieldsTest3()
        {
            FirstField.SendKeys("09/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void OlderThanOrEqualToAllFieldsTest4()
        {
            FirstField.SendKeys("05/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanOrEqualToAllFieldsTest5()
        {
            FirstField.SendKeys("04/01/2014");
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }

        [TestMethod]
        public void OlderThanOrEqualToAllFieldsTest6()
        {
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class OlderThanOrEqualToAllFieldsTests_NoJS : OlderThanOrEqualToAllFieldsTests
    {}
}