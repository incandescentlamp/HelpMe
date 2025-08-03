

namespace HelpMe.Infrastructure.Experience.HttpRemote.Formatters;

/// <summary>
///     URL 参数格式化程序
/// </summary>
public interface IUrlParameterFormatter
{
    /// <summary>
    ///     格式化
    /// </summary>
    /// <param name="value">参数值</param>
    /// <param name="context">
    ///     <see cref="UrlFormattingContext" />
    /// </param>
    /// <returns>
    ///     <see cref="string" />
    /// </returns>
    public string? Format(object? value, UrlFormattingContext context);
}