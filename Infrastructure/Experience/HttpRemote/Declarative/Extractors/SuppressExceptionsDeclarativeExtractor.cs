



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="SuppressExceptionsAttribute" /> 特性提取器
/// </summary>
internal sealed class SuppressExceptionsDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [SuppressExceptions] 特性
        if (!context.IsMethodDefined<SuppressExceptionsAttribute>(out var suppressExceptionsAttribute, true))
        {
            return;
        }

        // 设置异常抑制
        httpRequestBuilder.SuppressExceptions(suppressExceptionsAttribute.Types);
    }
}