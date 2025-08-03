

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式 HTTP 版本特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class HttpVersionAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="HttpVersionAttribute" />
    /// </summary>
    /// <param name="version">HTTP 版本</param>
    public HttpVersionAttribute(string? version) => Version = version;

    /// <summary>
    ///     HTTP 版本
    /// </summary>
    public string? Version { get; set; }
}