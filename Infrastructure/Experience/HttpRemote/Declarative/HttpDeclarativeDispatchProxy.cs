

using HelpMe.Infrastructure.Experience.HttpRemote.Models;
using System.Reflection;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative;

/// <summary>
///     HTTP 声明式远程请求代理类
/// </summary>
public class HttpDeclarativeDispatchProxy : DispatchProxyAsync
{
    /// <inheritdoc cref="IHttpRemoteService" />
    public IHttpRemoteService RemoteService { get; internal set; } = null!;

    /// <inheritdoc />
    public override object Invoke(MethodInfo method, object[] args) => RemoteService.Declarative(method, args)!;

    /// <inheritdoc />
    public override async Task InvokeAsync(MethodInfo method, object[] args) =>
        _ = await InvokeAsyncT<VoidContent>(method, args);

    /// <inheritdoc />
    public override async Task<T> InvokeAsyncT<T>(MethodInfo method, object[] args) =>
        (await RemoteService.DeclarativeAsync<T>(method, args))!;
}