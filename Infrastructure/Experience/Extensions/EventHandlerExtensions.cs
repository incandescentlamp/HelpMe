using HelpMe.Infrastructure.Experience.Diagnostics;

namespace HelpMe.Infrastructure.Experience.Extensions;

/// <summary>
///     <see cref="EventHandler{TEventArgs}" /> 拓展类
/// </summary>
internal static class EventHandlerExtensions
{
    /// <summary>
    ///     尝试执行事件处理程序
    /// </summary>
    /// <param name="handler">
    ///     <see cref="EventHandler{TEventArgs}" />
    /// </param>
    /// <param name="sender">
    ///     <see cref="object" />
    /// </param>
    /// <param name="args">
    ///     <typeparamref name="TEventArgs" />
    /// </param>
    /// <typeparam name="TEventArgs">事件参数</typeparam>
    internal static void TryInvoke<TEventArgs>(this EventHandler<TEventArgs>? handler, object? sender, TEventArgs args)
    {
        // 空检查
        if (handler is null)
        {
            return;
        }

        try
        {
            handler(sender, args);
        }
        catch (Exception e)
        {
            // 输出调试事件
            Debugging.Error(e.Message);
        }
    }
}