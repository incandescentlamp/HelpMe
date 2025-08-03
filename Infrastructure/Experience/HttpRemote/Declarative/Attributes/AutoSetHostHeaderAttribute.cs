

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式设置自动 <c>Host</c> 标头特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class AutoSetHostHeaderAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="AutoSetHostHeaderAttribute" />
    /// </summary>
    public AutoSetHostHeaderAttribute()
        : this(true)
    {
    }

    /// <summary>
    ///     <inheritdoc cref="AutoSetHostHeaderAttribute" />
    /// </summary>
    /// <param name="enabled">是否启用</param>
    public AutoSetHostHeaderAttribute(bool enabled) => Enabled = enabled;

    /// <summary>
    ///     是否启用
    /// </summary>
    public bool Enabled { get; set; }
}