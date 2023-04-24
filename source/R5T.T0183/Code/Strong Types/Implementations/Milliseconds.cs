using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0183
{
    /// <inheritdoc cref="IMilliseconds"/>
    [StrongTypeImplementationMarker]
    public class Milliseconds : TypedBase<int>, IStrongTypeImplementationMarker,
        IMilliseconds
    {
        public Milliseconds(int value)
            : base(value)
        {
        }
    }
}
