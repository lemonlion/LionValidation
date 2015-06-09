using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DateNotEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [DateNotEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}