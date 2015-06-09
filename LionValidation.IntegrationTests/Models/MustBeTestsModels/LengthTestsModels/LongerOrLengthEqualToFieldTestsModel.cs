using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerOrLengthEqualToFieldTestsModel : TestsBaseModel
    {
        [LongerOrLengthEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}