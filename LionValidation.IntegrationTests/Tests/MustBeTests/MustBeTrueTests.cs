using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class MustBeTrueTests : TestsBase
    {
        [TestMethod]
        public void MustBeTrueTest1()
        {
            BooleanOneField.Click();
            Validate();
            Assert.IsTrue(BooleanOneField.IsValid());
        }

        [TestMethod]
        public void MustBeTrueTest2()
        {
            Validate();
            Assert.IsTrue(BooleanOneField.IsInvalid());
        }
    }

    [TestClass]
    public class MustBeTrueTests_NoJS : MustBeTrueTests
    { }
}