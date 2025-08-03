namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes.Methods;

/// <summary>
///     HTTP 声明式 TRACE 请求方式特性
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class TraceAttribute : HttpMethodAttribute
{
    /// <summary>
    ///     <inheritdoc cref="TraceAttribute" />
    /// </summary>
    /// <param name="requestUri">请求地址</param>
    public TraceAttribute(string? requestUri = null)
        : base(HttpMethod.Trace, requestUri)
    {
    }
}