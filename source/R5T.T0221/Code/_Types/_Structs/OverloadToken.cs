﻿using System;

using R5T.T0142;


namespace R5T.T0221
{
    /// <summary>
    /// A struct (so that no instance actually has to be created for out parameters), with a dummy type parameter (meant to specify the output type of the function),
    /// meant for use as an "out" input argument to a function allowing for easy function overload specification.
    /// <para>
    /// NOTE: if a function overload provides an overload token, the caller should <string>always</string> take care to specify the type (instead of using the "var" keyword)
    /// even if there is currently only one function overload with an overload token.
    /// This is because there might be more in the future, and if someone adds another in the future, all your call sites will now be ambiguous!
    /// </para>
    /// However, generally the variable name of the overload token can be omitted (use the "_" discard variable name).
    /// </summary>
    /// <remarks>
    /// Since C# does not differentiate function overloads based on output parameter type, only input parameter types,
    /// well make an input parameter that specifies the output type so that function overloads are still differentiated.
    /// </remarks>
    /// <typeparam name="T">Dummy type parameter, meant to specify the output type of a function in overloads.</typeparam>
    [UtilityTypeMarker]
    public struct OverloadToken<T>
    {
    }
}