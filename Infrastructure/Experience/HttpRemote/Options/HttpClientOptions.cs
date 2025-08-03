



using Microsoft.Extensions.Options;
using System.Text.Json;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Options;

/// <summary>
///     <see cref="HttpClient" /> 配置选项
/// </summary>
public sealed class HttpClientOptions
{
    /// <summary>
    ///     JSON 序列化配置
    /// </summary>
    public JsonSerializerOptions JsonSerializerOptions { get; set; } =
        new(HttpRemoteOptions.JsonSerializerOptionsDefault);

    /// <summary>
    ///     标识选项是否配置为默认值（未配置）
    /// </summary>
    /// <remarks>用于避免通过 <see cref="IOptionsSnapshot{TOptions}" /> 获取选项时无法确定是否已配置该选项。默认值为：<c>true</c>。</remarks>
    internal bool IsDefault { get; set; } = true;
}