



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="DisableCacheAttribute" /> 特性提取器
/// </summary>
internal sealed class DisableCacheDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [DisableCache] 特性
        if (!context.IsMethodDefined<DisableCacheAttribute>(out var disableCacheAttribute, true))
        {
            return;
        }

        // 设置禁用 HTTP 缓存
        httpRequestBuilder.DisableCache(disableCacheAttribute.Disabled);
    }
}