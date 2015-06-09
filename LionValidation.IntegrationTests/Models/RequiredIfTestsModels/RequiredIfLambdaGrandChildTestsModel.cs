using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfLambdaGrandChildTestsModel :  TestsBaseModel
    {
        [RequiredIfLambda("LambdaExpressionGrandChild")]
        public new string FirstField { get; set; }
    }
}