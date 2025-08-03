

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式请求基地址特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class BaseAddressAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="BaseAddressAttribute" />
    /// </summary>
    /// <param name="baseAddress">请求基地址</param>
    public BaseAddressAttribute(string? baseAddress) => BaseAddress = baseAddress;

    /// <summary>
    ///     请求基地址
    /// </summary>
    public string? BaseAddress { get; set; }
}