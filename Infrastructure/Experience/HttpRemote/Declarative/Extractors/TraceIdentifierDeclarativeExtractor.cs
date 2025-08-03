



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="TraceIdentifierAttribute" /> 特性提取器
/// </summary>
internal sealed class TraceIdentifierDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [TraceIdentifier] 特性
        if (!context.IsMethodDefined<TraceIdentifierAttribute>(out var traceIdentifierAttribute, true))
        {
            return;
        }

        // 设置跟踪标识
        httpRequestBuilder.SetTraceIdentifier(traceIdentifierAttribute.Identifier);
    }
}