

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式如果 HTTP 响应的 IsSuccessStatusCode 属性是 <c>false</c>，则引发异常特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class EnsureSuccessStatusCodeAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="EnsureSuccessStatusCodeAttribute" />
    /// </summary>
    public EnsureSuccessStatusCodeAttribute()
        : this(true)
    {
    }

    /// <summary>
    ///     <inheritdoc cref="EnsureSuccessStatusCodeAttribute" />
    /// </summary>
    /// <param name="enabled">是否启用</param>
    public EnsureSuccessStatusCodeAttribute(bool enabled) => Enabled = enabled;

    /// <summary>
    ///     是否启用
    /// </summary>
    public bool Enabled { get; set; }
}