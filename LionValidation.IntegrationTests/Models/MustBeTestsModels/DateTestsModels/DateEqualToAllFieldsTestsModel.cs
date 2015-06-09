using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DateEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [DateEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}