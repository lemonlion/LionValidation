using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class UKDateStrictTestsModel : TestsBaseModel
    {
        [UKDateString(UseStrict.True)]
        public new string FirstField { get; set; }
    }
}