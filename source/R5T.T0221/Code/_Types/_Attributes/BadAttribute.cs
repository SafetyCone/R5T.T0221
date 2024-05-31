using System;

using R5T.T0142;


namespace R5T.T0221
{
    /// <summary>
    /// Similar to the <see cref="ObsoleteAttribute"/>, but indicates that the application element is bad in some way.
    /// </summary>
    /// <remarks>
    /// Allowed on all application elements.
    /// Multiple are allowed (although discouraged).
    /// Inherited is false; just because the base class is bad doesn't mean all derived classes are.
    /// </remarks>
    [UtilityTypeMarker]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class BadAttribute : Attribute
    {
        public string Message { get; set; }


        public BadAttribute(
            string message)
        {
            this.Message = message;
        }
    }
}
