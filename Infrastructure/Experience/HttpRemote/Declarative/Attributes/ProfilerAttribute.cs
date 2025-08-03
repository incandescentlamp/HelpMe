

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式启用请求分析工具特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class ProfilerAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="ProfilerAttribute" />
    /// </summary>
    public ProfilerAttribute()
        : this(true)
    {
    }

    /// <summary>
    ///     <inheritdoc cref="ProfilerAttribute" />
    /// </summary>
    /// <param name="enabled">是否启用</param>
    public ProfilerAttribute(bool enabled) => Enabled = enabled;

    /// <summary>
    ///     是否启用
    /// </summary>
    public bool Enabled { get; set; }
}