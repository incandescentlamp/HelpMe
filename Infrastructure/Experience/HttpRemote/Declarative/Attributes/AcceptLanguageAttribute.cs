

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式客户端所偏好的自然语言和区域特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class AcceptLanguageAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="AcceptLanguageAttribute" />
    /// </summary>
    /// <param name="language">自然语言和区域设置</param>
    public AcceptLanguageAttribute(string? language) => Language = language;

    /// <summary>
    ///     客户端偏好的语言和区域
    /// </summary>
    public string? Language { get; set; }
}