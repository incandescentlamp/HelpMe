using HelpMe.Infrastructure.TaskQueue.Dependencies;

namespace HelpMe.Infrastructure.TaskQueue;

/// <summary>
/// 任务队列静态类
/// </summary>
public class TaskQueued
{
    private ITaskQueue taskQueue { get; set; }

    public TaskQueued(ITaskQueue queue)
    {
        taskQueue = queue;
    }

    /// <summary>
    /// 任务项入队
    /// </summary>
    /// <param name="taskHandler">任务处理委托</param>
    /// <param name="delay">延迟时间（毫秒）</param>
    /// <param name="channel">任务通道</param>
    /// <param name="taskId">任务 Id</param>
    /// <param name="concurrent">是否采用并行执行</param>
    /// <param name="runOnceIfDelaySet">配置是否设置了延迟执行后立即执行一次</param>
    /// <returns><see cref="object"/></returns>
    public object Enqueue(Action<IServiceProvider> taskHandler, int delay = 0, string channel = null, object taskId = null, bool? concurrent = null, bool runOnceIfDelaySet = false)
    {
        return taskQueue.Enqueue(taskHandler, delay, channel, taskId, concurrent, runOnceIfDelaySet);
    }

    /// <summary>
    /// 任务项入队
    /// </summary>
    /// <param name="taskHandler">任务处理委托</param>
    /// <param name="delay">延迟时间（毫秒）</param>
    /// <param name="channel">任务通道</param>
    /// <param name="taskId">任务 Id</param>
    /// <param name="concurrent">是否采用并行执行</param>
    /// <param name="runOnceIfDelaySet">配置是否设置了延迟执行后立即执行一次</param>
    /// <returns><see cref="ValueTask"/></returns>
    public async ValueTask<object> EnqueueAsync(Func<IServiceProvider, CancellationToken, ValueTask> taskHandler, int delay = 0, string channel = null, object taskId = null, bool? concurrent = null, bool runOnceIfDelaySet = false)
    {
        return await taskQueue.EnqueueAsync(taskHandler, delay, channel, taskId, concurrent, runOnceIfDelaySet);
    }
}