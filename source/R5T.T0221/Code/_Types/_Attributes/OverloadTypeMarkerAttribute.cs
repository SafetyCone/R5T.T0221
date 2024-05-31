using System;

using R5T.T0143;


namespace R5T.T0221
{
    /// <summary>
    /// Attribute indicating a struct is an overload type markers (a dummy struct that provides a type for use in differentiating between overloaded methods using the overload token).
    /// The marker attribute is useful for surveying structs that are overload type markers.
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class OverloadTypeMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsOverloadTypeMarker;
        /// <summary>
        /// Allows specifying that a struct is *not* an overload type marker.
        /// This is useful for marking structs that end up canonical overload type marker file locations, but are not overload type markers.
        /// </summary>
        public bool IsOverloadTypeMarker
        {
            get
            {
                return this.zIsOverloadTypeMarker;
            }
        }


        public OverloadTypeMarkerAttribute(
            bool isOverloadTypeMarker = true)
        {
            this.zIsOverloadTypeMarker = isOverloadTypeMarker;
        }
    }
}
