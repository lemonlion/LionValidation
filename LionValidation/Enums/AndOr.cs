namespace LionValidation.Enums
{
    public enum AndOr
    {
        /// <summary>
        /// Equivalent of ' && '
        /// </summary>
        And,
        /// <summary>
        /// Equivalent of ' || '
        /// </summary>
        Or,

        /// <summary>
        ///  Equivalent of <![CDATA[ ' && ( ' ]]>
        /// </summary>
        And_C,
        /// <summary>
        /// Equivalent of <![CDATA[ ' ) && ' ]]>
        /// </summary>
        Ɔ_And,
        /// <summary>
        /// Equivalent of <![CDATA[ ' ) && ( ' ]]>
        /// </summary>
        Ɔ_And_C,

        /// <summary>
        ///  Equivalent of <![CDATA[ ' && (( ' ]]>
        /// </summary>
        And_CC,
        /// <summary>
        /// Equivalent of <![CDATA[ ' )) && ' ]]>
        /// </summary>
        ƆƆ_And,
        /// <summary>
        ///  Equivalent of <![CDATA[ ' ) && (( ' ]]>
        /// </summary>
        Ɔ_And_CC,
        /// <summary>
        /// Equivalent of <![CDATA[ ' )) && ( ' ]]>
        /// </summary>
        ƆƆ_And_C,
        /// <summary>
        /// Equivalent of <![CDATA[ ' )) && (( ' ]]>
        /// </summary>
        ƆƆ_And_CC,

        /// <summary>
        /// Equivalent of <![CDATA[ ' || ( ' ]]>
        /// </summary>
        Or_C,
        /// <summary>
        /// Equivalent of <![CDATA[ ' ) || ' ]]>
        /// </summary>
        Ɔ_Or,
        /// <summary>
        /// Equivalent of <![CDATA[ ' ) || ( ' ]]>
        /// </summary>
        Ɔ_Or_C,

        /// <summary>
        /// Equivalent of <![CDATA[ ' || (( ' ]]>
        /// </summary>
        Or_CC,
        /// <summary>
        /// Equivalent of <![CDATA[ ' )) || ' ]]>
        /// </summary>
        ƆƆ_Or,
        /// <summary>
        /// Equivalent of <![CDATA[ ' ) || (( ' ]]>
        /// </summary>
        Ɔ_Or_CC,
        /// <summary>
        /// Equivalent of <![CDATA[ ' )) || ( ' ]]>
        /// </summary>
        ƆƆ_Or_C,
        /// <summary>
        /// Equivalent of <![CDATA[ ' )) || (( ' ]]>
        /// </summary>
        ƆƆ_Or_CC,
    }
}