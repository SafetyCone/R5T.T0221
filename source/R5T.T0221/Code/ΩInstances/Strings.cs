using System;


namespace R5T.T0221
{
    public class Strings : IStrings
    {
        #region Infrastructure

        public static IStrings Instance { get; } = new Strings();


        private Strings()
        {
        }

        #endregion
    }
}
