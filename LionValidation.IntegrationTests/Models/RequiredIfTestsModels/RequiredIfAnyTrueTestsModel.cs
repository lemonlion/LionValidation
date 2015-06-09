using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAnyTrueTestsModel :  TestsBaseModel
    {
        [RequiredIfAnyTrue("BooleanOneField", "BooleanTwoField")]
        public new string FirstField { get; set; }
    }
}