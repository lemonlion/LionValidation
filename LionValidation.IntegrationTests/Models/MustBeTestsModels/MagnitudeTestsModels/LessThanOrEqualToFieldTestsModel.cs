using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanOrEqualToFieldTestsModel : TestsBaseModel
    {
        [LessThanOrEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}