








using HelpMe.Infrastructure.Experience.HttpRemote.Models;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Handlers;

/// <summary>
///     HTTP 文件传输事件处理程序
/// </summary>
public interface IHttpFileTransferEventHandler
{
    /// <summary>
    ///     用于处理在文件开始传输时的操作
    /// </summary>
    void OnTransferStarted();

    /// <summary>
    ///     用于传输进度发生变化时的操作
    /// </summary>
    /// <param name="fileTransferProgress">
    ///     <see cref="FileTransferProgress" />
    /// </param>
    /// <returns>
    ///     <see cref="Task" />
    /// </returns>
    Task OnProgressChangedAsync(FileTransferProgress fileTransferProgress);

    /// <summary>
    ///     用于处理在文件传输完成时的操作
    /// </summary>
    /// <param name="duration">总耗时（毫秒）</param>
    void OnTransferCompleted(long duration);

    /// <summary>
    ///     用于处理在文件传输发生异常时的操作
    /// </summary>
    /// <param name="exception">
    ///     <see cref="Exception" />
    /// </param>
    void OnTransferFailed(Exception exception);
}