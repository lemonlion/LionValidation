using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LengthEqualToAnyTestsModel : TestsBaseModel
    {
        [LengthEqualToAny(5, 10)]
        public new string FirstField { get; set; }
    }
}