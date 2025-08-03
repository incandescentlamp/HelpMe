








using HelpMe.Infrastructure.Experience.HttpRemote.Converters;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Factories;

/// <inheritdoc cref="IObjectContentConverterFactory" />
internal sealed class ObjectContentConverterFactory : IObjectContentConverterFactory
{
    /// <inheritdoc />
    public ObjectContentConverter<TResult> GetConverter<TResult>() => new();

    /// <inheritdoc />
    public ObjectContentConverter GetConverter(Type resultType) => new();
}