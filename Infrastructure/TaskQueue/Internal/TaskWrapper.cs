﻿namespace HelpMe.Infrastructure.TaskQueue.Internal;

/// <summary>
/// 任务包装器
/// </summary>
public sealed class TaskWrapper
{
    /// <summary>
    /// 任务通道
    /// </summary>
    public string Channel { get; internal set; } = string.Empty;

    /// <summary>
    /// 任务 ID
    /// </summary>
    public object TaskId { get; internal set; }

    /// <summary>
    /// 任务处理委托
    /// </summary>
    public Func<IServiceProvider, CancellationToken, ValueTask> Handler { get; internal set; }

    /// <summary>
    /// 是否采用并行执行
    /// </summary>
    public bool? Concurrent { get; internal set; }
}