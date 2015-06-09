namespace LionValidation.ValidationAttributes
{
    public class NegativeOrZeroIntAttribute : IntAttribute
    {
        public NegativeOrZeroIntAttribute()
            : base(IntType.NegativeOrZero)
        {}
    }
}