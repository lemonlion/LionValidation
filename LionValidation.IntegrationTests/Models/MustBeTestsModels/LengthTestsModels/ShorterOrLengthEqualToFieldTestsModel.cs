using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterOrLengthEqualToFieldTestsModel : TestsBaseModel
    {
        [ShorterOrLengthEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}