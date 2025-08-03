



using HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;
using HelpMe.Infrastructure.HttpRemote;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式 <see cref="BaseAddressAttribute" /> 特性提取器
/// </summary>
internal sealed class BaseAddressDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <inheritdoc />
    public void Extract(HttpRequestBuilder httpRequestBuilder, HttpDeclarativeExtractorContext context)
    {
        // 检查方法或接口是否贴有 [BaseAddress] 特性
        if (!context.IsMethodDefined<BaseAddressAttribute>(out var baseAddressAttribute, true))
        {
            return;
        }

        // 设置请求基地址
        httpRequestBuilder.SetBaseAddress(baseAddressAttribute.BaseAddress);
    }
}