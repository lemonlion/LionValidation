using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DoesntContainFieldTestsModel : TestsBaseModel
    {
        [DoesntContainField("SecondField")]
        public new string FirstField { get; set; }
    }
}