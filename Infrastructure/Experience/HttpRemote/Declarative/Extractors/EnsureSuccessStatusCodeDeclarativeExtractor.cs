



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="EnsureSuccessStatusCodeAttribute" /> 特性提取器
/// </summary>
internal sealed class EnsureSuccessStatusCodeDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [EnsureSuccessStatusCode] 特性
        if (!context.IsMethodDefined<EnsureSuccessStatusCodeAttribute>(out var ensureSuccessStatusCodeAttribute, true))
        {
            return;
        }

        // 设置是否如果 HTTP 响应的 IsSuccessStatusCode 属性是 false，则引发异常
        httpRequestBuilder.EnsureSuccessStatusCode(ensureSuccessStatusCodeAttribute.Enabled);
    }
}