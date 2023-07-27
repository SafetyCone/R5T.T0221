using System;


namespace R5T.T0221
{
    /// <inheritdoc cref="IEnvironmentVariable"/>
    public class EnvironmentVariable : IEnvironmentVariable
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
