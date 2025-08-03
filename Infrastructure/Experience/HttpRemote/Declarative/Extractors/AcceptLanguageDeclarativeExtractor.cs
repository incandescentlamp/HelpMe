



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="AcceptLanguageAttribute" /> 特性提取器
/// </summary>
internal sealed class AcceptLanguageDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [AcceptLanguage] 特性
        if (!context.IsMethodDefined<AcceptLanguageAttribute>(out var acceptLanguageAttribute, true))
        {
            return;
        }

        // 设置客户端所偏好的自然语言和区域设置
        httpRequestBuilder.AcceptLanguage(acceptLanguageAttribute.Language);
    }
}