using System;

using R5T.T0142;


namespace R5T.T0221
{
    /// <summary>
    /// A string-based environment variable.
    /// </summary>
    [DataTypeMarker]
    public interface IEnvironmentVariable
    {
        public string Name { get; }
        public string Value { get; }
    }
}
