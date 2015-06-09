namespace LionValidation.ValidationAttributes
{
    public class PositiveOrZeroIntAttribute : IntAttribute
    {
        public PositiveOrZeroIntAttribute()
            : base(IntType.PositiveOrZero)
        {}
    }
}