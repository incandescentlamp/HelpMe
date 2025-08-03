namespace HelpMe.Infrastructure.Experience.HttpRemote.Converters;

/// <summary>
///     <see cref="IHttpContentConverter{TResult}" /> 内容处理器基类
/// </summary>
/// <typeparam name="TResult">转换的目标类型</typeparam>
public abstract class HttpContentConverterBase<TResult> : IHttpContentConverter<TResult>
{
    /// <inheritdoc />
    public IServiceProvider? ServiceProvider { get; set; }

    /// <inheritdoc />
    public abstract TResult? Read(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public abstract Task<TResult?> ReadAsync(HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public virtual object? Read(Type resultType, HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        Read(httpResponseMessage, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<object?> ReadAsync(Type resultType, HttpResponseMessage httpResponseMessage,
        CancellationToken cancellationToken = default) =>
        await ReadAsync(httpResponseMessage, cancellationToken);
}