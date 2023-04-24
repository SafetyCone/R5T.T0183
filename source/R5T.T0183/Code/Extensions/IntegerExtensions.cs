using System;


namespace R5T.T0183.Extensions
{
    public static class IntegerExtensions
    {
        public static Milliseconds ToMilliseconds(this int value)
        {
            return Instances.IntegerOperator.ToMilliseconds(value);
        }
    }
}
