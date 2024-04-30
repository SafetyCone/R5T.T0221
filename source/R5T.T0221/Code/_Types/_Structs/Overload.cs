using System;


namespace R5T.T0221
{
    /// <summary>
    /// A struct (so that no instance actually has to be created for out parameters), with a dummy type parameter (meant to specify the output type of the function),
    /// meant for use as an "out" input argument to a function allowing for easy function overload specification.
    /// </summary>
    /// <remarks>
    /// Since C# does not differentiate function overloads based on output parameter type, only input parameter types,
    /// well make an input parameter that specifies the output type so that function overloads are still differentiated.
    /// </remarks>
    /// <typeparam name="T">Dummy type parameter, meant to specify the output type of a function in overloads.</typeparam>
    public struct Overload<T>
    {
    }
}
