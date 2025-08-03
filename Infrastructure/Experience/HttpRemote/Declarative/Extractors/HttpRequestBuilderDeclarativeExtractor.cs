



using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="HttpRequestBuilder" /> 自定义配置提取器
/// </summary>
internal sealed class HttpRequestBuilderDeclarativeExtractor : IFrozenHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 尝试解析单个 Action<HttpRequestBuilder> 类型参数
        if (context.Args.SingleOrDefault(u => u is Action<HttpRequestBuilder>) is Action<HttpRequestBuilder>
            requestBuilderAction)
        {
            requestBuilderAction.Invoke(httpRequestBuilder);
        }
    }

    /// <inheritdoc />
    public int Order => 1;
}