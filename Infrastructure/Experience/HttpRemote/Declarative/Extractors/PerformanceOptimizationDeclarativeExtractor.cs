



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="PerformanceOptimizationAttribute" /> 特性提取器
/// </summary>
internal sealed class PerformanceOptimizationDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [PerformanceOptimization] 特性
        if (!context.IsMethodDefined<PerformanceOptimizationAttribute>(out var performanceOptimizationAttribute, true))
        {
            return;
        }

        // 设置是否启用性能优化
        httpRequestBuilder.PerformanceOptimization(performanceOptimizationAttribute.Enabled);
    }
}