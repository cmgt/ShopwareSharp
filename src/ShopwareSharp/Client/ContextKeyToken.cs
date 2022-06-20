using System;

namespace ShopwareSharp.Client;

/// <summary>
/// A token constructed from an contextKey
/// </summary>
public class ContextKeyToken : TokenBase
{
    /// <summary>
    /// Constructs an ContextKeyToken object.
    /// </summary>
    /// <param name="value"></param>
    public ContextKeyToken(string value)
    {
        raw = value;
    }

    public static readonly ContextKeyToken Unit = new ContextKeyToken(String.Empty);
}