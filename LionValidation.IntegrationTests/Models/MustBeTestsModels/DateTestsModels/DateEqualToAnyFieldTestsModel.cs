using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DateEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [DateEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}