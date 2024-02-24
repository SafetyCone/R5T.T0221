using System;


namespace R5T.T0221
{
    public class IsSetOperator : IIsSetOperator
    {
        #region Infrastructure

        public static IIsSetOperator Instance { get; } = new IsSetOperator();


        private IsSetOperator()
        {
        }

        #endregion
    }
}
