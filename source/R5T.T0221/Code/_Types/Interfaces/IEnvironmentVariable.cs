using System;


namespace R5T.T0221
{
    /// <summary>
    /// A string-based environment variable.
    /// </summary>
    public interface IEnvironmentVariable
    {
        public string Name { get; }
        public string Value { get; }
    }
}
