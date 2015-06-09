using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the property's value is an integer
    /// </summary>
    public class IntAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the property's value is an integer
        /// </summary>
        public IntAttribute()
            : base(Operator.MatchesRegularExpression, RegexHelper.Integer)
        {}

        /// <summary>
        /// Validates that the property's value is an integer of the specified type
        /// </summary>
        /// <param name="intType">The type of integer allowed</param>
        public IntAttribute(IntType intType)
            : base(Operator.MatchesRegularExpression, GetRegex(intType))
        { }

        protected static string GetRegex(IntType intType)
        {
            switch (intType)
            {
                case IntType.All: return RegexHelper.Integer;
                case IntType.Positive: return RegexHelper.PositiveInteger;
                case IntType.PositiveOrZero: return RegexHelper.PositiveIntegerOrZero;
                case IntType.Negative: return RegexHelper.NegativeInteger;
                case IntType.NegativeOrZero: return RegexHelper.NegativeIntegerOrZero;
            }

            return RegexHelper.Integer;
        }
    }

    public enum IntType
    {
        All,
        Positive,
        PositiveOrZero,
        Negative,
        NegativeOrZero
    }
}