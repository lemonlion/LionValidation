using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DateNotEqualToAnyTestsModel : TestsBaseModel
    {
        [DateNotEqualToAny("05/01/2014", "10/01/2014")]
        public new string FirstField { get; set; }
    }
}