using System;

using R5T.T0131;


namespace R5T.T0221
{
    [ValuesMarker]
    public partial interface IStrings : IValuesMarker
    {
        /// <summary>
        /// <para><value>"disabled"</value></para>
        /// </summary>
        public string Disabled => "disabled";

        /// <summary>
        /// <para><value>"enabled"</value></para>
        /// </summary>
        public string Enabled => "enabled";
    }
}
