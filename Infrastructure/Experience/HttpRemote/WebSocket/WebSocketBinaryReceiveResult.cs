



using System.Net.WebSockets;

namespace HelpMe.Infrastructure.Experience.HttpRemote.WebSocket;

/// <summary>
///     WebSocket 接收的二进制消息的结果类
/// </summary>
public sealed class WebSocketBinaryReceiveResult : WebSocketReceiveResult
{
    /// <inheritdoc />
    public WebSocketBinaryReceiveResult(int count, bool endOfMessage)
        : base(count, WebSocketMessageType.Binary, endOfMessage)
    {
    }

    /// <inheritdoc />
    public WebSocketBinaryReceiveResult(int count, bool endOfMessage, WebSocketCloseStatus? closeStatus,
        string? closeStatusDescription)
        : base(count, WebSocketMessageType.Binary, endOfMessage, closeStatus, closeStatusDescription)
    {
    }

    /// <summary>
    ///     二进制消息
    /// </summary>
    public byte[] Message { get; internal init; } = null!;
}