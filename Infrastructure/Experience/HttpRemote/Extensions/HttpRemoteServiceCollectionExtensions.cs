



using HelpMe.Infrastructure.Experience.HttpRemote.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Extensions;

/// <summary>
///     HTTP 远程请求模块 <see cref="IServiceCollection" /> 拓展类
/// </summary>
public static class HttpRemoteServiceCollectionExtensions
{
    /// <summary>
    ///     添加 HTTP 远程请求服务
    /// </summary>
    /// <param name="services">
    ///     <see cref="IServiceCollection" />
    /// </param>
    /// <param name="configure">自定义配置委托</param>
    /// <returns>
    ///     <see cref="IHttpRemoteBuilder" />
    /// </returns>
    public static IHttpRemoteBuilder AddHttpRemote(this IServiceCollection services
        , Action<HttpRemoteBuilder>? configure = null)
    {
        // 初始化 HTTP 远程请求构建器
        var httpRemoteBuilder = new HttpRemoteBuilder();

        // 调用自定义配置委托
        configure?.Invoke(httpRemoteBuilder);

        return services.AddHttpRemote(httpRemoteBuilder);
    }

    /// <summary>
    ///     添加 HTTP 远程请求服务
    /// </summary>
    /// <param name="services">
    ///     <see cref="IServiceCollection" />
    /// </param>
    /// <param name="httpRemoteBuilder">
    ///     <see cref="HttpRemoteBuilder" />
    /// </param>
    /// <returns>
    ///     <see cref="IHttpRemoteBuilder" />
    /// </returns>
    public static IHttpRemoteBuilder AddHttpRemote(this IServiceCollection services,
        HttpRemoteBuilder httpRemoteBuilder)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(httpRemoteBuilder);

        // 构建模块服务
        httpRemoteBuilder.Build(services);

        return new DefaultHttpRemoteBuilder(services);
    }
}