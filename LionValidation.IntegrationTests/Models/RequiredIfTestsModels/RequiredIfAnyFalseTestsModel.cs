using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAnyFalseTestsModel :  TestsBaseModel
    {
        [RequiredIfAnyFalse("BooleanOneField", "BooleanTwoField")]
        public new string FirstField { get; set; }
    }
}