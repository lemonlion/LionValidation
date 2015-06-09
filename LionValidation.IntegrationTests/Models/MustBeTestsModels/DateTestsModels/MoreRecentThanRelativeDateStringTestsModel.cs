using LionValidation.Enums;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanRelativeDateStringTestsModel : TestsBaseModel
    {
        [MoreRecentThan("69 years, 11 months ago")]
        public new string FirstField { get; set; }
    }
}