

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式超时时间特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class TimeoutAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="TimeoutAttribute" />
    /// </summary>
    /// <param name="timeoutMilliseconds">超时时间（毫秒）</param>
    public TimeoutAttribute(double timeoutMilliseconds) => Timeout = timeoutMilliseconds;

    /// <summary>
    ///     超时时间（毫秒）
    /// </summary>
    public double Timeout { get; set; }
}