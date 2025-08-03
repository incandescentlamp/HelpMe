namespace HelpMe.Infrastructure.Experience.Attributes;

/// <summary>
///     设置别名特性
/// </summary>
[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
public sealed class AliasAsAttribute : Attribute
{
    /// <summary>
    ///     <inheritdoc cref="AliasAsAttribute" />
    /// </summary>
    /// <param name="aliasAs">别名</param>
    public AliasAsAttribute(string aliasAs) => AliasAs = aliasAs;

    /// <summary>
    ///     别名
    /// </summary>
    public string? AliasAs { get; set; }
}