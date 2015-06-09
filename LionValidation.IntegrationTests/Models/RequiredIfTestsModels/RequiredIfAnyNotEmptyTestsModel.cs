using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAnyNotEmptyTestsModel :  TestsBaseModel
    {
        [RequiredIfAnyNotEmpty("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}