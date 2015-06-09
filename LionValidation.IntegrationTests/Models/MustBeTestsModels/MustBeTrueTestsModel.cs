using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MustBeTrueTestsModel : TestsBaseModel
    {
        [MustBeTrue]
        public new bool BooleanOneField { get; set; }
    }
}