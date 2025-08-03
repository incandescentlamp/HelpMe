using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text;

namespace HelpMe.AspNetCore.Formatters;

/// <summary>
///     从请求正文中读取 <c>text/plain</c> 内容
/// </summary>
/// <remarks>参考文献：https://github.com/dotnet/aspnetcore/blob/main/src/Mvc/Mvc.Core/src/Formatters/SystemTextJsonInputFormatter.cs。</remarks>
public class TextPlainInputFormatter : TextInputFormatter, IInputFormatterExceptionPolicy
{
    /// <inheritdoc cref="TextPlainInputFormatter" />
    public TextPlainInputFormatter()
    {
        SupportedEncodings.Add(UTF8EncodingWithoutBOM);
        SupportedEncodings.Add(UTF16EncodingLittleEndian);

        SupportedMediaTypes.Add(MediaTypeNames.Text.Plain);
    }

    /// <inheritdoc />
    public InputFormatterExceptionPolicy ExceptionPolicy => InputFormatterExceptionPolicy.AllExceptions;

    /// <inheritdoc />
    public sealed override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context,
        Encoding encoding)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(encoding);

        // 获取 HttpContext 实例
        var httpContext = context.HttpContext;

        // 获取输入的流
        var (inputStream, usesTranscodingStream) = GetInputStream(httpContext, encoding);

        string? data;

        try
        {
            // 读取流中的字符串
            using var streamReader = new StreamReader(inputStream);
            data = await streamReader.ReadToEndAsync();
        }
        catch (Exception ex)
        {
            context.ModelState.TryAddModelError(string.Empty, ex, context.Metadata);

            return await InputFormatterResult.FailureAsync();
        }
        finally
        {
            if (usesTranscodingStream)
            {
                await inputStream.DisposeAsync();
            }
        }

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (data is null && !context.TreatEmptyInputAsDefaultValue)
        {
            return await InputFormatterResult.NoValueAsync();
        }

        return await InputFormatterResult.SuccessAsync(data);
    }

    /// <summary>
    ///     获取输入的流
    /// </summary>
    /// <param name="httpContext">
    ///     <see cref="HttpContext" />
    /// </param>
    /// <param name="encoding">
    ///     <see cref="Encoding" />
    /// </param>
    /// <returns>
    ///     <see cref="Tuple{T1, T2}" />
    /// </returns>
    internal static (Stream inputStream, bool usesTranscodingStream) GetInputStream(HttpContext httpContext,
        Encoding encoding)
    {
        if (encoding.CodePage == Encoding.UTF8.CodePage)
        {
            return (httpContext.Request.Body, false);
        }

        var inputStream = Encoding.CreateTranscodingStream(httpContext.Request.Body, encoding, Encoding.UTF8, true);

        return (inputStream, true);
    }
}