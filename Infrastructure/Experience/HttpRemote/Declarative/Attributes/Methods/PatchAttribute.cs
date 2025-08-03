﻿






namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes.Methods;

/// <summary>
///     HTTP 声明式 PATCH 请求方式特性
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class PatchAttribute : HttpMethodAttribute
{
    /// <summary>
    ///     <inheritdoc cref="PatchAttribute" />
    /// </summary>
    /// <param name="requestUri">请求地址</param>
    public PatchAttribute(string? requestUri = null)
        : base(HttpMethod.Patch, requestUri)
    {
    }
}