using System.Net.WebSockets;

namespace HelpMe.Infrastructure.Experience.HttpRemote.WebSocket;

/// <summary>
///     WebSocket 接收的文本消息的结果类
/// </summary>
public sealed class WebSocketTextReceiveResult : WebSocketReceiveResult
{
    /// <inheritdoc />
    public WebSocketTextReceiveResult(int count, bool endOfMessage)
        : base(count, WebSocketMessageType.Text, endOfMessage)
    {
    }

    /// <inheritdoc />
    public WebSocketTextReceiveResult(int count, bool endOfMessage, WebSocketCloseStatus? closeStatus,
        string? closeStatusDescription)
        : base(count, WebSocketMessageType.Text, endOfMessage, closeStatus, closeStatusDescription)
    {
    }

    /// <summary>
    ///     文本消息
    /// </summary>
    public string Message { get; internal init; } = null!;
}