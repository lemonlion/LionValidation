using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAllTrueTestsModel :  TestsBaseModel
    {
        [RequiredIfAllTrue("BooleanOneField", "BooleanTwoField")]
        public new string FirstField { get; set; }
    }
}