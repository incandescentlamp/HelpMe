using HelpMe.Infrastructure.Experience.Attributes;
using System.Reflection;

namespace HelpMe.Infrastructure.Experience.Utilities;

/// <summary>
///     提供别名获取实用方法
/// </summary>
public static class AliasAsUtility
{
    /// <summary>
    ///     获取属性名
    /// </summary>
    /// <param name="property">
    ///     <see cref="PropertyInfo" />
    /// </param>
    /// <param name="isDefined">是否定义特性</param>
    /// <returns>
    ///     <see cref="string" />
    /// </returns>
    public static string GetPropertyName(PropertyInfo property, out bool isDefined)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(property);

        // 获取属性名
        var name = property.Name;

        // 检查属性是否贴有 [AliasAs] 特性
        if (!property.IsDefined(typeof(AliasAsAttribute)))
        {
            isDefined = false;
            return name;
        }

        // 获取 AliasAsAttribute 实例的 AliasAs 属性值
        var aliasAs = property.GetCustomAttribute<AliasAsAttribute>()!.AliasAs;

        // 空检查
        if (!string.IsNullOrWhiteSpace(aliasAs))
        {
            name = aliasAs.Trim();
        }

        isDefined = true;
        return name;
    }

    /// <summary>
    ///     获取参数名
    /// </summary>
    /// <param name="parameter">
    ///     <see cref="ParameterInfo" />
    /// </param>
    /// <param name="isDefined">是否定义特性</param>
    /// <returns>
    ///     <see cref="string" />
    /// </returns>
    public static string GetParameterName(ParameterInfo parameter, out bool isDefined)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(parameter);

        // 获取参数名
        var name = parameter.Name!;

        // 检查参数是否贴有 [AliasAs] 特性
        if (!parameter.IsDefined(typeof(AliasAsAttribute)))
        {
            isDefined = false;
            return name;
        }

        // 获取 AliasAsAttribute 实例的 AliasAs 属性值
        var aliasAs = parameter.GetCustomAttribute<AliasAsAttribute>()!.AliasAs;

        // 空检查
        if (!string.IsNullOrWhiteSpace(aliasAs))
        {
            name = aliasAs.Trim();
        }

        isDefined = true;
        return name;
    }
}