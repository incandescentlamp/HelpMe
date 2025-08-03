﻿

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes.Methods;

/// <summary>
///     HTTP 声明式 HEAD 请求方式特性
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class HeadAttribute : HttpMethodAttribute
{
    /// <summary>
    ///     <inheritdoc cref="HeadAttribute" />
    /// </summary>
    /// <param name="requestUri">请求地址</param>
    public HeadAttribute(string? requestUri = null)
        : base(HttpMethod.Head, requestUri)
    {
    }
}