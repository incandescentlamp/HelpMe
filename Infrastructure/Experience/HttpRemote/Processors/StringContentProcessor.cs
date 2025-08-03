



using HelpMe.Infrastructure.Experience.Extensions;
using HelpMe.Infrastructure.Experience.HttpRemote.Options;
using HelpMe.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Processors;

/// <summary>
///     字符串内容处理器
/// </summary>
public class StringContentProcessor : HttpContentProcessorBase
{
    /// <inheritdoc />
    public override bool CanProcess(object? rawContent, string contentType) =>
        rawContent is StringContent or JsonContent ||
        contentType.IsIn([
            MediaTypeNames.Application.Json,
            MediaTypeNames.Application.JsonPatch,
            MediaTypeNames.Application.Xml,
            MediaTypeNames.Application.XmlPatch,
            MediaTypeNames.Text.Xml,
            MediaTypeNames.Text.Html,
            MediaTypeNames.Text.Plain,
            MediaTypeNames.Application.Soap // SOAP 1.2
        ], StringComparer.OrdinalIgnoreCase);

    /// <inheritdoc />
    public override HttpContent? Process(object? rawContent, string contentType, Encoding? encoding)
    {
        // 尝试解析 HttpContent 类型
        if (TryProcess(rawContent, contentType, encoding, out var httpContent))
        {
            return httpContent;
        }

        // 将原始请求内容转换为字符串
        var content = rawContent.GetType().IsBasicType() || rawContent is JsonElement or JsonNode
            ? rawContent.ToCultureString(CultureInfo.InvariantCulture)
            : JsonSerializer.Serialize(rawContent,
                ServiceProvider?.GetRequiredService<IOptions<HttpRemoteOptions>>().Value.JsonSerializerOptions ??
                HttpRemoteOptions.JsonSerializerOptionsDefault);

        // 初始化 StringContent 实例
        var stringContent = new StringContent(content!, encoding,
            new MediaTypeHeaderValue(contentType) { CharSet = encoding?.BodyName });

        return stringContent;
    }
}