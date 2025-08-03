

namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Extractors;

/// <summary>
///     HTTP 声明式提取器排序（冻结）
/// </summary>
public interface IFrozenHttpDeclarativeExtractor : IHttpDeclarativeExtractor
{
    /// <summary>
    ///     获取提取器的顺序值。值越小，提取器越晚被调用
    /// </summary>
    int Order { get; }
}