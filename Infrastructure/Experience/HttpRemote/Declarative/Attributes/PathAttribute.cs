﻿

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式路径参数特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface, AllowMultiple = true)]
public sealed class PathAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="PathAttribute" />
    /// </summary>
    /// <param name="name">参数名称</param>
    /// <param name="value">参数值</param>
    public PathAttribute(string name, object? value)
    {
        // 空检查
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        Name = name;
        Value = value;
    }

    /// <summary>
    ///     路径参数键
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     路径参数的值
    /// </summary>
    public object? Value { get; set; }
}