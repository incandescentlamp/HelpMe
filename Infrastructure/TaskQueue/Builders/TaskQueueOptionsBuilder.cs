﻿namespace HelpMe.Infrastructure.TaskQueue.Builders;

/// <summary>
/// 任务队列配置选项构建器
/// </summary>
public sealed class TaskQueueOptionsBuilder
{
    /// <summary>
    /// 默认内置任务队列内存通道容量
    /// </summary>
    /// <remarks>超过 n 条待处理消息，第 n+1 条将进入等待，默认为 12000</remarks>
    public int ChannelCapacity { get; set; } = 12000;

    /// <summary>
    /// 未察觉任务异常事件处理程序
    /// </summary>
    public EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskExceptionHandler { get; set; }

    /// <summary>
    /// 是否采用并行执行
    /// </summary>
    public bool Concurrent { get; set; } = true;

    /// <summary>
    /// 重试次数（默认 3 次）
    /// </summary>
    public int NumRetries { get; set; } = 3;

    /// <summary>
    /// 重试间隔（默认 1000ms）
    /// </summary>
    public int RetryTimeout { get; set; } = 1000;

    /// <summary>
    /// 构建任务配置选项
    /// </summary>
    internal void Build()
    {
    }
}