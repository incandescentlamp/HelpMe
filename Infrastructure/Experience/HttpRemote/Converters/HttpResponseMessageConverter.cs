namespace HelpMe.Infrastructure.Experience.HttpRemote.Converters;

/// <summary>
///     <see cref="HttpResponseMessage" /> 内容转换器
/// </summary>
public class HttpResponseMessageConverter : HttpContentConverterBase<HttpResponseMessage>
{
    /// <inheritdoc />
    public override HttpResponseMessage? Read(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        httpResponseMessage;

    /// <inheritdoc />
    public override Task<HttpResponseMessage?> ReadAsync(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        Task.FromResult<HttpResponseMessage?>(httpResponseMessage);
}