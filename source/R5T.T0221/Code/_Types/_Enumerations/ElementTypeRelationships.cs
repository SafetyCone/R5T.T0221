using System;

using R5T.T0142;


namespace R5T.N0000
{
    /// <summary>
    /// For types with an element type (<see cref="Type.HasElementType"/>, like array, pointer, or reference), this flags enumeration describes the relationship.
    /// </summary>
    [Flags]
    [DataTypeMarker]
    public enum ElementTypeRelationships
    {
        /// <summary>
        /// Allows representing no relationship between types.
        /// </summary>
        None =
            0,

        /// <summary>
        /// The type is an array.
        /// </summary>
        Array =
            1 << 0,

        /// <summary>
        /// The type is a reference.
        /// </summary>
        Reference =
            1 << 1,

        /// <summary>
        /// The type is a pointer.
        /// </summary>
        Pointer =
            1 << 2
    }
}
