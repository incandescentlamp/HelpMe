using HelpMe.Infrastructure.Experience.HttpRemote.Models;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Converters;

/// <summary>
///     <see cref="VoidContent" /> 内容转换器
/// </summary>
public class VoidContentConverter : HttpContentConverterBase<VoidContent>
{
    /// <inheritdoc />
    public override VoidContent? Read(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) => null;

    /// <inheritdoc />
    public override Task<VoidContent?> ReadAsync(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        Task.FromResult<VoidContent?>(null);
}