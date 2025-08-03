



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="AutoSetHostHeaderAttribute" /> 特性提取器
/// </summary>
internal sealed class AutoSetHostHeaderDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [AutoSetHostHeader] 特性
        if (!context.IsMethodDefined<AutoSetHostHeaderAttribute>(out var autoSetHostHeaderAttribute, true))
        {
            return;
        }

        // 设置是否自动设置 Host 标头
        httpRequestBuilder.AutoSetHostHeader(autoSetHostHeaderAttribute.Enabled);
    }
}