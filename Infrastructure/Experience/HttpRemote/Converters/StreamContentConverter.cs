namespace HelpMe.Infrastructure.Experience.HttpRemote.Converters;

/// <summary>
///     流内容转换器
/// </summary>
public class StreamContentConverter : HttpContentConverterBase<Stream>
{
    /// <inheritdoc />
    public override Stream? Read(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        httpResponseMessage.Content.ReadAsStream(cancellationToken);

    /// <inheritdoc />
    public override async Task<Stream?> ReadAsync(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        await httpResponseMessage.Content.ReadAsStreamAsync(cancellationToken);
}