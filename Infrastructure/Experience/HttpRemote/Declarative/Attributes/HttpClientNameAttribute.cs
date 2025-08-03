

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式 <see cref="HttpClient" /> 实例的配置名称特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class HttpClientNameAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="HttpClientNameAttribute" />
    /// </summary>
    /// <param name="name"><see cref="HttpClient" /> 实例的配置名称</param>
    public HttpClientNameAttribute(string? name) => Name = name;

    /// <summary>
    ///     <see cref="HttpClient" /> 实例的配置名称
    /// </summary>
    public string? Name { get; set; }
}