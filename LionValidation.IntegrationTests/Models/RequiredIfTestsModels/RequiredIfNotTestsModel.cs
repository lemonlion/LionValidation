using System.ComponentModel;
using LionValidation.Enums;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfNotTestsModel :  TestsBaseModel
    {
        [RequiredIfNot("SecondField", Operator.EqualTo, "ForbiddenTestData")]
        public new string FirstField { get; set; }
    }
}