using System;

using R5T.T0132;


namespace R5T.T0221
{
    [FunctionalityMarker]
    public partial interface IIsSetOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Expresses that if <typeparamref name="T"/> is set, then <typeparamref name="TImplication"/> is also set.
        /// </summary>
        public IsSet<TImplication> Implies<TImplication, T>(IsSet<T> _)
        {
            return new IsSet<TImplication>();
        }

        public IsSet<T> IsSet<T>()
        {
            var output = new IsSet<T>();
            return output;
        }

        public (IsSet<T1>, IsSet<T2>, IsSet<T3>) IsSet<T1, T2, T3>()
        {
            var output = (new IsSet<T1>(), new IsSet<T2>(), new IsSet<T3>());
            return output;
        }

        public void Require<T>(IsSet<T> _)
        {
            // Do nothing, just communicate the the property is required to be set.
        }
    }
}
