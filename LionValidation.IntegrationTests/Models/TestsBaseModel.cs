using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace LionValidation.IntegrationTests.Models
{
    public class  TestsBaseModel
    {
        public bool UseServerValidationOnly { get; set; }

        public string FirstField { get; set; }

        public string SecondField { get; set; }

        public string ThirdField { get; set; }

        public string FourthField { get; set; }

        public bool BooleanOneField { get; set; }

        public bool BooleanTwoField { get; set; }

        public int? IntField { get; set; }

        public ChildTestModel Child { get; set; }

        public static Expression<Func<TestsBaseModel, bool>> LambdaExpressionGrandChild { get { return x => x.Child.ChildFirstField.GrandChildFirstField == "ValidTestData"; } }

        public bool IsFinishedValidating { get; set; }
    }

    public class ChildTestModel
    {
        public GrandChildTestModel ChildFirstField { get; set; }
    }

    public class GrandChildTestModel
    {
        public string GrandChildFirstField { get; set; }

        public string GrandChildSecondField { get; set; }
    }
}
