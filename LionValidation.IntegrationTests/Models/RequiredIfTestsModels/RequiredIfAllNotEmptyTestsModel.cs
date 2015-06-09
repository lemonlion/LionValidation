using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAllNotEmptyTestsModel :  TestsBaseModel
    {
        [RequiredIfAllNotEmpty("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}