﻿






namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes.Methods;

/// <summary>
///     HTTP 声明式 POST 请求方式特性
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class PostAttribute : HttpMethodAttribute
{
    /// <summary>
    ///     <inheritdoc cref="PostAttribute" />
    /// </summary>
    /// <param name="requestUri">请求地址</param>
    public PostAttribute(string? requestUri = null)
        : base(HttpMethod.Post, requestUri)
    {
    }
}