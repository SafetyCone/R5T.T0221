using System;


namespace R5T.T0221
{
    public class EnabledOperator : IEnabledOperator
    {
        #region Infrastructure

        public static IEnabledOperator Instance { get; } = new EnabledOperator();


        private EnabledOperator()
        {
        }

        #endregion
    }
}
