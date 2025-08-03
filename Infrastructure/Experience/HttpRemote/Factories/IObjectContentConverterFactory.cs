






































using HelpMe.Infrastructure.Experience.HttpRemote.Converters;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Factories;

/// <summary>
///     <see cref="ObjectContentConverter{TResult}" /> 工厂
/// </summary>
public interface IObjectContentConverterFactory
{
    /// <summary>
    ///     获取 <see cref="ObjectContentConverter{TResult}" /> 实例
    /// </summary>
    /// <typeparam name="TResult">转换的目标类型</typeparam>
    /// <returns>
    ///     <see cref="ObjectContentConverter{TResult}" />
    /// </returns>
    ObjectContentConverter<TResult> GetConverter<TResult>();

    /// <summary>
    ///     获取 <see cref="ObjectContentConverter" /> 实例
    /// </summary>
    /// <param name="resultType">转换的目标类型</param>
    /// <returns>
    ///     <see cref="ObjectContentConverter" />
    /// </returns>
    ObjectContentConverter GetConverter(Type resultType);
}