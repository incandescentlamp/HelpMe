

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式跟踪标识特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class TraceIdentifierAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="TraceIdentifierAttribute" />
    /// </summary>
    /// <param name="traceIdentifier">跟踪标识</param>
    public TraceIdentifierAttribute(string traceIdentifier) => Identifier = traceIdentifier;

    /// <summary>
    ///     跟踪标识
    /// </summary>
    public string Identifier { get; set; }
}