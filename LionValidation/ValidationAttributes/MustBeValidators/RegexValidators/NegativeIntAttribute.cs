namespace LionValidation.ValidationAttributes
{
    public class NegativeIntAttribute : IntAttribute
    {
        public NegativeIntAttribute()
            : base(IntType.Negative)
        {}
    }
}