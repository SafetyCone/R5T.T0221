using System;

using R5T.T0142;


namespace R5T.T0221
{
    /// <summary>
    /// A struct (so that no instance actually has to be created for out parameters), with a dummy type parameter (meant to specify the output type of the function),
    /// meant for use as an "out" input argument to a function that facilitates communication of whether a function ensures some result internally (or if that result
    /// must be ensured externally).
    /// <para>You can use the name of the function parameter to communicate the ensurance afforded by the function.</para>
    /// </summary>
    /// <remarks>
    /// You often want to ensure some end result (for example, that values have been ordered alphabetically).
    /// The question is, for a function caller, do you have to ensure that result? Or does the function already internally ensure that result?
    /// If the function has an "out" parameter communicating the ensured result, then the function ensures the result.
    /// <para>
    /// Generally callers can omit the type name and variable name of the ensured token (use the "_" discard keyword).
    /// This is because the ensurance token is only meant to be consumed from the intellisense of a method.
    /// </para>
    /// </remarks>
    [UtilityTypeMarker]
    public struct EnsuredToken
    {
    }

    /// <inheritdoc cref="EnsuredToken"/>
    /// <typeparam name="T">Dummy type parameter, meant to specify the ensurance type.</typeparam>
    [UtilityTypeMarker]
    public struct EnsuredToken<T>
    {
    }
}
