using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class MustBeFalseTests : TestsBase
    {
        [TestMethod]
        public void MustBeFalseTest1()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(BooleanOneField.IsInvalid());
        }

        [TestMethod]
        public void MustBeFalseTest2()
        {
            Validate();
            Assert.IsTrue(BooleanOneField.IsValid());
        }
    }

    [TestClass]
    public class MustBeFalseTests_NoJS : MustBeFalseTests
    { }
}