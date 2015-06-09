using System.ComponentModel;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfNotEmptyTestsModel :  TestsBaseModel
    {
        [RequiredIfNotEmpty("SecondField")]
        public new string FirstField { get; set; }
    }
}