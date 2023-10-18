using System;

using R5T.T0142;


namespace R5T.T0221
{
    /// <inheritdoc cref="IEnvironmentVariable"/>
    [DataTypeMarker]
    public class EnvironmentVariable : IEnvironmentVariable
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
