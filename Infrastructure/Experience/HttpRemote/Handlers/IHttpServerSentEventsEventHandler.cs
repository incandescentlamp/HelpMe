








using HelpMe.Infrastructure.Experience.HttpRemote.Models;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Handlers;

/// <summary>
///     Server-Sent Events 事件处理程序
/// </summary>
public interface IHttpServerSentEventsEventHandler
{
    /// <summary>
    ///     用于在与事件源的连接打开时的操作
    /// </summary>
    void OnOpen();

    /// <summary>
    ///     用于在从事件源接收到数据时的操作
    /// </summary>
    /// <param name="serverSentEventsData">
    ///     <see cref="ServerSentEventsData" />
    /// </param>
    /// <param name="cancellationToken">
    ///     <see cref="CancellationToken" />
    /// </param>
    /// <returns>
    ///     <see cref="Task" />
    /// </returns>
    Task OnMessageAsync(ServerSentEventsData serverSentEventsData, CancellationToken cancellationToken);

    /// <summary>
    ///     用于在事件源连接未能打开时的操作
    /// </summary>
    /// <param name="exception">
    ///     <see cref="Exception" />
    /// </param>
    void OnError(Exception exception);
}