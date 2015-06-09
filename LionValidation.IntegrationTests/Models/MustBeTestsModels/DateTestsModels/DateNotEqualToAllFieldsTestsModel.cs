using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DateNotEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [DateNotEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}