using System;
using LionValidation.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LionValidation.UnitTests
{
    [TestClass]
    public class TestBase
    {
        public ValidationStatement ValidationStatement { get; set; }

        [TestInitialize]
        public void TestInitialise()
        {
            ValidationStatement = new ValidationStatement("Property1", Operator.EqualTo, "Value1");
        }
    }
}
