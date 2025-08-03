



using HelpMe.Infrastructure.Extensions;
using System.Net.Mime;
using System.Text;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Processors;

/// <summary>
///     多部分表单内容数据内容处理器
/// </summary>
public class MultipartFormDataContentProcessor : HttpContentProcessorBase
{
    /// <inheritdoc />
    public override bool CanProcess(object? rawContent, string contentType) =>
        rawContent is MultipartFormDataContent ||
        contentType.IsIn([MediaTypeNames.Multipart.FormData], StringComparer.OrdinalIgnoreCase);

    /// <inheritdoc />
    public override HttpContent? Process(object? rawContent, string contentType, Encoding? encoding)
    {
        // 尝试解析 HttpContent 类型
        if (TryProcess(rawContent, contentType, encoding, out var httpContent))
        {
            return httpContent;
        }

        throw new NotImplementedException();
    }
}