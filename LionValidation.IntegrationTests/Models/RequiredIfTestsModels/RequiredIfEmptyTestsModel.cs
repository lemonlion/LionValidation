using System.ComponentModel;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfEmptyTestsModel :  TestsBaseModel
    {
        [RequiredIfEmpty("SecondField")]
        [DisplayName("Required If Second Field Empty")]
        public new string FirstField { get; set; }
    }
}