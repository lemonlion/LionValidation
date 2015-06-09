using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanOrEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [LessThanOrEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}