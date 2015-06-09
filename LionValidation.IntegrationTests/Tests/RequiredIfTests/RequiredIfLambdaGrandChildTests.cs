using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class RequiredIfLambdaGrandChildTests : TestsBase
    {
        [TestMethod]
        public void RequiredIfLambdaGrandChildTest1()
        {
            GrandChildFirstField.SendKeys("ValidTestData");
            Validate();
            Assert.IsTrue(FirstField.IsInvalid());
        }

        [TestMethod]
        public void RequiredIfLambdaGrandChildTest2()
        {
            SecondField.Clear();
            Validate();
            Assert.IsTrue(FirstField.IsValid());
        }
    }

    [TestClass]
    public class RequiredIfLambdaGrandChildTests_NoJS : RequiredIfLambdaGrandChildTests
    {}
}