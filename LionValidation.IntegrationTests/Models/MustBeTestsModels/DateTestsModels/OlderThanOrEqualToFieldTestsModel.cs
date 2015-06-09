using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanOrEqualToFieldTestsModel : TestsBaseModel
    {
        [OlderThanOrEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}