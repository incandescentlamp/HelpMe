using HelpMe.Infrastructure.Experience.Extensions;
using HelpMe.Infrastructure.Extensions;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Processors;

/// <summary>
///     URL 编码的表单内容处理器
/// </summary>
public class FormUrlEncodedContentProcessor : HttpContentProcessorBase
{
    /// <inheritdoc />
    public override bool CanProcess(object? rawContent, string contentType) =>
        rawContent is FormUrlEncodedContent || contentType.IsIn([MediaTypeNames.Application.FormUrlEncoded],
            StringComparer.OrdinalIgnoreCase);

    /// <inheritdoc />
    public override HttpContent? Process(object? rawContent, string contentType, Encoding? encoding)
    {
        // 尝试解析 HttpContent 类型
        if (TryProcess(rawContent, contentType, encoding, out var httpContent))
        {
            return httpContent;
        }

        // 将原始请求类型转换为字符串字典类型
        var nameValueCollection = rawContent.ObjectToDictionary()!
            .ToDictionary(u => u.Key.ToCultureString(CultureInfo.InvariantCulture)!,
                u => u.Value?.ToCultureString(CultureInfo.InvariantCulture)
            );

        // 初始化 FormUrlEncodedContent 实例
        var formUrlEncodedContent = new FormUrlEncodedContent(nameValueCollection);
        formUrlEncodedContent.Headers.ContentType =
            new MediaTypeHeaderValue(contentType) { CharSet = encoding?.BodyName };

        return formUrlEncodedContent;
    }
}