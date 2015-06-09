using LionValidation.Enums;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanRelativeDateEnumTestsModel : TestsBaseModel
    {
        [MoreRecentThan(DateOf.FortyEightDaysAgo)]
        public new string FirstField { get; set; }
    }
}