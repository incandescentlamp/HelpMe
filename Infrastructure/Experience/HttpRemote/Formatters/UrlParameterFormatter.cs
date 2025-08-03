



using HelpMe.Infrastructure.Experience.Extensions;
using System.Globalization;

namespace HelpMe.Infrastructure.Experience.HttpRemote.Formatters;

/// <inheritdoc cref="IUrlParameterFormatter" />
public class UrlParameterFormatter : IUrlParameterFormatter
{
    /// <inheritdoc />
    public virtual string? Format(object? value, UrlFormattingContext context) =>
        value?.ToCultureString(CultureInfo.InvariantCulture);
}