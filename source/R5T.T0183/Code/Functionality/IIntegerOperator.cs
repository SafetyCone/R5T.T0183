using System;

using R5T.T0132;


namespace R5T.T0183
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        public Milliseconds ToMilliseconds(int value)
        {
            var output = new Milliseconds(value);
            return output;
        }
    }
}
