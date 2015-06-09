using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LengthEqualToFieldTestsModel : TestsBaseModel
    {
        [LengthEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}