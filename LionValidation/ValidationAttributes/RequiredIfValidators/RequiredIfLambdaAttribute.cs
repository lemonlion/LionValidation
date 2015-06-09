namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if a lambda expression evaluates to true.
    /// </summary>
    public class RequiredIfLambdaAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if a lambda expression evaluates to true.
        /// </summary>
        /// <param name="lambdaExpressionStringOrFieldName">A lambda expression string or the name of a lambda property to check for a true value</param>
        public RequiredIfLambdaAttribute(string lambdaExpressionStringOrFieldName)
            : base(lambdaExpressionStringOrFieldName)
        {}
    }
}