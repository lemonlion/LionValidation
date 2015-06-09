using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAllFalseTestsModel :  TestsBaseModel
    {
        [RequiredIfAllFalse("BooleanOneField", "BooleanTwoField")]
        public new string FirstField { get; set; }
    }
}