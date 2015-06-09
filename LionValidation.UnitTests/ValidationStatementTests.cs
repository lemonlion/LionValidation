using System;
using LionValidation.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.UnitTests
{
    [TestClass]
    public class ValidationStatementTests : TestBase
    {
        [TestMethod]
        public void ValidationStatementTest1()
        {
            Assert.IsTrue(ValidationStatement.Evaluate(new ClassToValidate { Property1 = "Value1" })); 
        }

        [TestMethod]
        public void ValidationStatementTest2()
        {
            Assert.IsFalse(ValidationStatement.Evaluate(new ClassToValidate { Property1 = "Value2" }));
        }
    }
}
