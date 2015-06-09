using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MustBeFalseTestsModel : TestsBaseModel
    {
        [MustBeFalse]
        public new bool BooleanOneField { get; set; }
    }
}