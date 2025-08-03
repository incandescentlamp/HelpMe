namespace HelpMe.Infrastructure.Experience.HttpRemote.Converters;

/// <summary>
///     字符串内容转换器
/// </summary>
public class StringContentConverter : HttpContentConverterBase<string>
{
    /// <inheritdoc />
    public override string? Read(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        httpResponseMessage.Content.ReadAsStringAsync(cancellationToken).GetAwaiter().GetResult();

    /// <inheritdoc />
    public override async Task<string?> ReadAsync(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken);
}