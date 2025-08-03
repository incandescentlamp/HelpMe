






namespace HelpMe.Infrastructure.Experience.HttpRemote.Declarative.Attributes;

/// <summary>
///     HTTP 声明式多部分表单对象内容特性
/// </summary>
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class MultipartObjectAttribute : MultipartAttribute
{
    /// <summary>
    ///     <inheritdoc cref="MultipartObjectAttribute" />
    /// </summary>
    public MultipartObjectAttribute() => AsFormItem = false;
}