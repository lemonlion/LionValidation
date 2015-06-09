using System;

namespace LionValidation.Helpers
{
    public static class LambdaHelper
    {
        public static string Lambda<T>(this T y, Func<T, bool> lambda)
        {
            return string.Empty;
        }
    }
}