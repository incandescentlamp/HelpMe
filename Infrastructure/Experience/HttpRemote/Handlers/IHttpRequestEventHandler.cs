

namespace HelpMe.Infrastructure.Experience.HttpRemote.Handlers;

/// <summary>
///     HTTP 远程请求事件处理程序
/// </summary>
public interface IHttpRequestEventHandler
{
    /// <summary>
    ///     用于处理在发送 HTTP 请求之前的操作
    /// </summary>
    /// <param name="httpRequestMessage">
    ///     <see cref="HttpRequestMessage" />
    /// </param>
    void OnPreSendRequest(HttpRequestMessage httpRequestMessage);

    /// <summary>
    ///     用于处理在收到 HTTP 响应之后的操作
    /// </summary>
    /// <param name="httpResponseMessage">
    ///     <see cref="HttpResponseMessage" />
    /// </param>
    void OnPostReceiveResponse(HttpResponseMessage httpResponseMessage);

    /// <summary>
    ///     用于处理在发送 HTTP 请求发生异常时的操作
    /// </summary>
    /// <param name="exception">
    ///     <see cref="Exception" />
    /// </param>
    /// <param name="httpResponseMessage">
    ///     <see cref="HttpResponseMessage" />
    /// </param>
    void OnRequestFailed(Exception exception, HttpResponseMessage? httpResponseMessage);
}