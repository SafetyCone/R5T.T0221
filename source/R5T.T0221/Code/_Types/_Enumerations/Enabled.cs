using System;

using R5T.T0142;


namespace R5T.N0000
{
    /// <summary>
    /// A simple enabled/disabled toggle.
    /// Disabled the default.
    /// </summary>
    [DataTypeMarker]
    public enum Enabled
    {
        /// <summary>
        /// Disabled - the default value.
        /// </summary>
        Disabled =
            0,

        /// <summary>
        /// Enabled
        /// </summary>
        Enabled = 1
    }
}
