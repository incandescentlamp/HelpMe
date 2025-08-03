



using HelpMe.Infrastructure.HttpRemote;









namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式提取器
/// </summary>
public interface IHttpDeclarativeExtractor
{
    /// <summary>
    ///     提取方法信息构建 <see cref="HttpRequestBuilder" /> 实例
    /// </summary>
    /// <param name="httpRequestBuilder">
    ///     <see cref="HttpRequestBuilder" />
    /// </param>
    /// <param name="context">
    ///     <see cref="HttpDeclarativeExtractorContext" />
    /// </param>
    void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context);
}