



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="ProfilerAttribute" /> 特性提取器
/// </summary>
internal sealed class ProfilerDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [Profiler] 特性
        if (!context.IsMethodDefined<ProfilerAttribute>(out var profilerAttribute, true))
        {
            return;
        }

        // 设置是否启用请求分析工具
        httpRequestBuilder.Profiler(profilerAttribute.Enabled);
    }
}