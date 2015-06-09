using LionValidation.Enums;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanRelativeDateEnumTestsModel : TestsBaseModel
    {
        [OlderThan(DateOf.FortyEightDaysFromNow)]
        public new string FirstField { get; set; }
    }
}