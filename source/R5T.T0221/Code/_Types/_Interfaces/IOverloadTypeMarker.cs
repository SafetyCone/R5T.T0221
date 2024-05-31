using System;


namespace R5T.T0221
{
    /// <summary>
    /// Marker interface for structs that are overload type markers (dummy structs that provide a type for use in differentiating between overloaded methods using the overload token).
    /// Allows methods-for, and extension methods-on, all types that are overload type markers.
    /// </summary>
    public interface IOverloadTypeMarker
    {
    }
}
