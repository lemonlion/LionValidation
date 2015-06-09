using LionValidation.Enums;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanRelativeDateStringTestsModel : TestsBaseModel
    {
        [OlderThan("69 years, 11 months from now")]
        public new string FirstField { get; set; }
    }
}