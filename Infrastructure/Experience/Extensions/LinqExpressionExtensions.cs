using System.Linq.Expressions;
using System.Reflection;

namespace HelpMe.Infrastructure.Experience.Extensions;

/// <summary>
///     <see cref="Expression" /> 拓展类
/// </summary>
internal static class LinqExpressionExtensions
{
    /// <summary>
    ///     根据条件成立构建 <c>Where</c> 表达式
    /// </summary>
    /// <param name="source">
    ///     <see cref="IEnumerable{TSource}" />
    /// </param>
    /// <param name="condition">条件</param>
    /// <param name="predicate"><c>Where</c> 表达式</param>
    /// <typeparam name="TSource">集合元素类型</typeparam>
    /// <returns>
    ///     <see cref="IEnumerable{TSource}" />
    /// </returns>
    internal static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source
        , bool condition
        , Func<TSource, bool> predicate)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(predicate);

        return !condition
            ? source
            : source.Where(predicate);
    }

    /// <summary>
    ///     解析表达式并获取属性的 <see cref="PropertyInfo" /> 实例
    /// </summary>
    /// <typeparam name="T">对象类型</typeparam>
    /// <typeparam name="TProperty">属性类型</typeparam>
    /// <param name="propertySelector">
    ///     <see cref="Expression{TDelegate}" />
    /// </param>
    /// <returns>
    ///     <see cref="PropertyInfo" />
    /// </returns>
    /// <exception cref="ArgumentException"></exception>
    internal static PropertyInfo GetProperty<T, TProperty>(this Expression<Func<T, TProperty?>> propertySelector) =>
        propertySelector.Body switch
        {
            // 检查 Lambda 表达式的主体是否是 MemberExpression 类型
            MemberExpression memberExpression => GetProperty<T>(memberExpression),
            // 如果主体是 UnaryExpression 类型，则继续解析
            UnaryExpression { Operand: MemberExpression nestedMemberExpression } => GetProperty<T>(
                nestedMemberExpression),
            _ => throw new ArgumentException("Expression must be a simple member access (e.g. x => x.Property).",
                nameof(propertySelector))
        };

    /// <summary>
    ///     从成员表达式中提取 <see cref="PropertyInfo" /> 实例
    /// </summary>
    /// <param name="memberExpression">
    ///     <see cref="MemberExpression" />
    /// </param>
    /// <typeparam name="T">对象类型</typeparam>
    /// <returns>
    ///     <see cref="PropertyInfo" />
    /// </returns>
    /// <exception cref="ArgumentException"></exception>
    internal static PropertyInfo GetProperty<T>(MemberExpression memberExpression)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(memberExpression);

        // 确保表达式根是 T 类型的参数
        if (memberExpression.Expression is not ParameterExpression parameterExpression ||
            parameterExpression.Type != typeof(T))
        {
            throw new ArgumentException(
                $"Expression '{memberExpression}' must refer to a member of type '{typeof(T)}'.",
                nameof(memberExpression));
        }

        // 确保成员是属性（非字段）
        if (memberExpression.Member is not PropertyInfo propertyInfo)
        {
            throw new ArgumentException(
                $"Expression '{memberExpression}' refers to a field. Only properties are supported.",
                nameof(memberExpression));
        }

        return propertyInfo;
    }
}