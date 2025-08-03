﻿namespace HelpMe.Infrastructure.TaskQueue.Events;

/// <summary>
/// 任务处理委托事件参数
/// </summary>
public sealed class TaskHandlerEventArgs : EventArgs
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="taskId">任务 Id</param>
    /// <param name="channel">任务通道</param>
    /// <param name="success">任务处理委托调用结果</param>
    public TaskHandlerEventArgs(object taskId, string channel, bool success)
    {
        TaskId = taskId;
        Channel = channel;
        Status = success ? "SUCCESS" : "FAIL";
    }

    /// <summary>
    /// 任务 Id
    /// </summary>
    public object TaskId { get; }

    /// <summary>
    /// 任务通道
    /// </summary>
    public string Channel { get; }

    /// <summary>
    /// 执行状态
    /// </summary>
    public string Status { get; }

    /// <summary>
    /// 异常信息
    /// </summary>
    public Exception Exception { get; internal set; }
}