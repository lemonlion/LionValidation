using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanOrEqualToFieldTestsModel : TestsBaseModel
    {
        [GreaterThanOrEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}