

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式请求来源地址特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class RefererAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="RefererAttribute" />
    /// </summary>
    /// <param name="referer">请求来源地址，当设置为 <c>"{BASE_ADDRESS}"</c> 时将替换为基地址</param>
    public RefererAttribute(string? referer) => Referer = referer;

    /// <summary>
    ///     请求来源地址，当设置为 <c>"{BASE_ADDRESS}"</c> 时将替换为基地址
    /// </summary>
    public string? Referer { get; set; }
}