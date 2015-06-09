using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAllEmptyTestsModel :  TestsBaseModel
    {
        [RequiredIfAllEmpty("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}