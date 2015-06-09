using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DobOlderThan21TestsModel : TestsBaseModel
    {
        [DobOlderThan21]
        public new string FirstField { get; set; }
    }
}