using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DateNotEqualToFieldTestsModel : TestsBaseModel
    {
        [DateNotEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}