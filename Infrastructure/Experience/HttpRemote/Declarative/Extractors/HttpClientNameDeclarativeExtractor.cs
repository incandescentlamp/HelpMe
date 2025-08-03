



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="HttpClientNameAttribute" /> 特性提取器
/// </summary>
internal sealed class HttpClientNameDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [HttpClientName] 特性
        if (!context.IsMethodDefined<HttpClientNameAttribute>(out var httpClientNameAttribute, true))
        {
            return;
        }

        // 设置 HttpClient 实例的配置名称
        httpRequestBuilder.SetHttpClientName(httpClientNameAttribute.Name);
    }
}