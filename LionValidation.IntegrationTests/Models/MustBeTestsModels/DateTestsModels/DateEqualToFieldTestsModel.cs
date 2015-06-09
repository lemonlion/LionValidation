using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DateEqualToFieldTestsModel : TestsBaseModel
    {
        [DateEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}