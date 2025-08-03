



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="RefererAttribute" /> 特性提取器
/// </summary>
internal sealed class RefererDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [Referer] 特性
        if (!context.IsMethodDefined<RefererAttribute>(out var refererAttribute, true))
        {
            return;
        }

        // 设置请求来源地址
        httpRequestBuilder.SetReferer(refererAttribute.Referer);
    }
}