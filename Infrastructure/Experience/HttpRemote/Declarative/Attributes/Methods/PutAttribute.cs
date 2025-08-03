﻿






namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes.Methods;

/// <summary>
///     HTTP 声明式 PUT 请求方式特性
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class PutAttribute : HttpMethodAttribute
{
    /// <summary>
    ///     <inheritdoc cref="PutAttribute" />
    /// </summary>
    /// <param name="requestUri">请求地址</param>
    public PutAttribute(string? requestUri = null)
        : base(HttpMethod.Put, requestUri)
    {
    }
}