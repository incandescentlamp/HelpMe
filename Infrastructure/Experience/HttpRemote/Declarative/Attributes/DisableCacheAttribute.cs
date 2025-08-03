

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式禁用 HTTP 缓存特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class DisableCacheAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="DisableCacheAttribute" />
    /// </summary>
    public DisableCacheAttribute()
        : this(true)
    {
    }

    /// <summary>
    ///     <inheritdoc cref="DisableCacheAttribute" />
    /// </summary>
    /// <param name="disabled">是否禁用</param>
    public DisableCacheAttribute(bool disabled) => Disabled = disabled;

    /// <summary>
    ///     是否禁用
    /// </summary>
    public bool Disabled { get; set; }
}