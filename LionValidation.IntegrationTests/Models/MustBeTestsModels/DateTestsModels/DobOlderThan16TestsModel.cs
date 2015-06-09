using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DobOlderThan16TestsModel : TestsBaseModel
    {
        [DobOlderThan16]
        public new string FirstField { get; set; }
    }
}