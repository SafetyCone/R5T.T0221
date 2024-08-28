using System;

using R5T.T0142;


namespace R5T.T0221
{
    /// <summary>
    /// Instances are used to communicate that certain values have been set.
    /// </summary>
    /// <typeparam name="T">A dummy type that communicates what is set.</typeparam>
    [UtilityTypeMarker]
    public readonly struct IsSet<T>
    {
        #region Static

        public static IsSet<T> Instance { get; }

        #endregion


        // No properties.
    }

    /// <summary>
    /// Instances are used to communicate that certain values have been set.
    /// </summary>
    /// <typeparam name="T">A dummy type that communicates what is set.</typeparam>
    [UtilityTypeMarker]
    public readonly struct IsSet_Input<T>
    {
        #region Static

        public static IsSet<T> Instance { get; }

        #endregion


        // No properties.
    }

    /// <summary>
    /// Instances are used to communicate that certain values have been set.
    /// </summary>
    /// <typeparam name="T">A dummy type that communicates what is set.</typeparam>
    [UtilityTypeMarker]
    public readonly struct IsSet_Output<T>
    {
        #region Static

        public static IsSet<T> Instance { get; }

        #endregion


        // No properties.
    }
}
