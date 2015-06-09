using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DobOlderThan18TestsModel : TestsBaseModel
    {
        [DobOlderThan18]
        public new string FirstField { get; set; }
    }
}