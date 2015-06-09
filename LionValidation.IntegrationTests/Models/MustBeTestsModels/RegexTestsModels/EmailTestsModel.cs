using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class EmailTestsModel : TestsBaseModel
    {
        [Email]
        public new string FirstField { get; set; }
    }
}