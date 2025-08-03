



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="TimeoutAttribute" /> 特性提取器
/// </summary>
internal sealed class TimeoutDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [Timeout] 特性
        if (!context.IsMethodDefined<TimeoutAttribute>(out var timeoutAttribute, true))
        {
            return;
        }

        // 设置超时时间
        httpRequestBuilder.SetTimeout(timeoutAttribute.Timeout);
    }
}