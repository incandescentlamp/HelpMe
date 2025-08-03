

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式异常抑制特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class SuppressExceptionsAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="SuppressExceptionsAttribute" />
    /// </summary>
    /// <remarks>抑制所有异常。</remarks>
    public SuppressExceptionsAttribute()
        : this(true)
    {
    }

    /// <summary>
    ///     <inheritdoc cref="SuppressExceptionsAttribute" />
    /// </summary>
    /// <param name="enabled">是否启用异常抑制。当设置为 <c>false</c> 时，将禁用异常抑制机制。</param>
    public SuppressExceptionsAttribute(bool enabled) => Types = enabled ? [typeof(Exception)] : [];

    /// <summary>
    ///     <inheritdoc cref="SuppressExceptionsAttribute" />
    /// </summary>
    /// <param name="types">异常抑制类型集合</param>
    public SuppressExceptionsAttribute(params Type[] types) => Types = types;

    /// <summary>
    ///     异常抑制类型集合
    /// </summary>
    public Type[] Types { get; set; }
}