using System.Runtime.InteropServices;

namespace HelpMe.Infrastructure.Experience.Utilities;

/// <summary>
///     提供运行时实用方法
/// </summary>
public static class RuntimeUtility
{
    /// <summary>
    ///     获取操作系统描述
    /// </summary>
    public static string OSDescription => RuntimeInformation.OSDescription;

    /// <summary>
    ///     获取操作系统基本名称
    /// </summary>
    /// <returns>
    ///     <see cref="string" />
    /// </returns>
    public static string GetOSName()
    {
        // 检查操作系统是否是 Windows 平台
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return "Windows";
        }

        // 检查操作系统是否是 Linux 平台
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return "Linux";
        }

        // 检查操作系统是否是 macOS 平台
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            return "macOS";
        }

        return "Unknown";
    }
}