



using System.Net.Http.Headers;
using System.Text;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Processors;

/// <summary>
///     <see cref="ReadOnlyMemory{T}" /> 内容处理器
/// </summary>
public class ReadOnlyMemoryContentProcessor : HttpContentProcessorBase
{
    /// <inheritdoc />
    public override bool CanProcess(object? rawContent, string contentType) =>
        rawContent is ReadOnlyMemoryContent or ReadOnlyMemory<byte>;

    /// <inheritdoc />
    public override HttpContent? Process(object? rawContent, string contentType, Encoding? encoding)
    {
        // 尝试解析 HttpContent 类型
        if (TryProcess(rawContent, contentType, encoding, out var httpContent))
        {
            return httpContent;
        }

        // 检查是否是 ReadOnlyMemory<byte> 类型
        if (rawContent is ReadOnlyMemory<byte> readOnlyMemory)
        {
            // 初始化 ReadOnlyMemoryContent 实例
            var readOnlyMemoryContent = new ReadOnlyMemoryContent(readOnlyMemory);
            readOnlyMemoryContent.Headers.ContentType = new MediaTypeHeaderValue(contentType)
            {
                CharSet = encoding?.BodyName
            };

            return readOnlyMemoryContent;
        }

        throw new InvalidOperationException(
            $"Expected a ReadOnlyMemory<byte>, but received an object of type `{rawContent.GetType()}`.");
    }
}