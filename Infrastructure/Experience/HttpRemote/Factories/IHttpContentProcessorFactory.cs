



using HelpMe.Infrastructure.Experience.HttpRemote.Processors;
using System.Text;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Factories;

/// <summary>
///     <see cref="IHttpContentProcessor" /> 工厂
/// </summary>
public interface IHttpContentProcessorFactory
{
    /// <summary>
    ///     <inheritdoc cref="IServiceProvider" />
    /// </summary>
    IServiceProvider ServiceProvider { get; }

    /// <summary>
    ///     构建 <see cref="HttpContent" /> 实例
    /// </summary>
    /// <param name="rawContent">原始请求内容</param>
    /// <param name="contentType">内容类型</param>
    /// <param name="encoding">内容编码</param>
    /// <param name="processors"><see cref="IHttpContentProcessor" /> 数组</param>
    /// <returns>
    ///     <see cref="HttpContent" />
    /// </returns>
    HttpContent? Build(object? rawContent, string contentType, Encoding? encoding = null,
        params IHttpContentProcessor[]? processors);
}