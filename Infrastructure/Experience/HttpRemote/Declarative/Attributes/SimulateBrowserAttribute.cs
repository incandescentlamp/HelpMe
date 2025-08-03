

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式模拟浏览器环境特性
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Interface)]
public sealed class SimulateBrowserAttribute : Attribute
{
    /// <summary>
    ///     是否模拟移动端，默认值为：<c>false</c>（即模拟桌面端）
    /// </summary>
    public bool Mobile { get; set; }
}