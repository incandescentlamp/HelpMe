



using HelpMe.Infrastructure.Experience.HttpRemote.Builders;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="HttpMultipartFormDataBuilder" /> 多部分表单内容配置提取器
/// </summary>
internal sealed class HttpMultipartFormDataBuilderDeclarativeExtractor : IFrozenHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 尝试解析单个 Action<HttpMultipartFormDataBuilder> 类型参数
        if (context.Args.SingleOrDefault(u => u is Action<HttpMultipartFormDataBuilder>) is not
            Action<HttpMultipartFormDataBuilder> multipartFormDataBuilderAction)
        {
            return;
        }

        // 处理和 [Multipart] 特性冲突问题
        if (httpRequestBuilder.MultipartFormDataBuilder is not null)
        {
            multipartFormDataBuilderAction.Invoke(httpRequestBuilder.MultipartFormDataBuilder);
        }
        else
        {
            // 设置多部分表单内容
            httpRequestBuilder.SetMultipartContent(multipartFormDataBuilderAction);
        }
    }

    /// <inheritdoc />
    public int Order => 2;
}