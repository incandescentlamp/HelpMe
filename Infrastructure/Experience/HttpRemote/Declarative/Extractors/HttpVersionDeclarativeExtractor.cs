



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="HttpVersionAttribute" /> 特性提取器
/// </summary>
internal sealed class HttpVersionDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [HttpVersion] 特性
        if (!context.IsMethodDefined<HttpVersionAttribute>(out var versionAttribute, true))
        {
            return;
        }

        // 设置 HTTP 版本
        httpRequestBuilder.SetVersion(versionAttribute.Version);
    }
}