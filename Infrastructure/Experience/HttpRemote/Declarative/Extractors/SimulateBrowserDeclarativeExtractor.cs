



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="SimulateBrowserAttribute" /> 特性提取器
/// </summary>
internal sealed class SimulateBrowserDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [SimulateBrowser] 特性
        if (!context.IsMethodDefined<SimulateBrowserAttribute>(out var simulateBrowserAttribute, true))
        {
            return;
        }

        // 设置模拟浏览器环境
        httpRequestBuilder.SimulateBrowser(simulateBrowserAttribute.Mobile);
    }
}