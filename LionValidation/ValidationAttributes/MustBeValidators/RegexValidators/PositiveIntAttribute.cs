namespace LionValidation.ValidationAttributes
{
    public class PositiveIntAttribute : IntAttribute
    {
        public PositiveIntAttribute()
            : base(IntType.Positive)
        {}
    }
}