using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class UKDateStringTestsModel : TestsBaseModel
    {
        [UKDateString]
        public new string FirstField { get; set; }
    }
}