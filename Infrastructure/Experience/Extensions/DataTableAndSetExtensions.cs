using HelpMe.Infrastructure.Experience.Extensions;
using System.Data;

namespace HelpMe.Infrastructure.Experience.Extensions;

/// <summary>
///     <see cref="DataTable" /> 和 <see cref="DataSet" /> 拓展类
/// </summary>
internal static class DataTableAndSetExtensions
{
    /// <summary>
    ///     将 <see cref="DataTable" /> 转换为字典集合
    /// </summary>
    /// <param name="dataTable">
    ///     <see cref="DataTable" />
    /// </param>
    /// <returns>
    ///     <see cref="List{T}" />
    /// </returns>
    internal static List<Dictionary<string, object?>> ToDictionaryList(this DataTable dataTable)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(dataTable);

        return dataTable.AsEnumerable().Select(row =>
            row.Table.Columns.Cast<DataColumn>()
                .ToDictionary(col => col.ColumnName, col => row[col] != DBNull.Value ? row[col] : null)).ToList();
    }

    /// <summary>
    ///     将 <see cref="DataSet" /> 转换为字典集合
    /// </summary>
    /// <param name="dataSet">
    ///     <see cref="DataSet" />
    /// </param>
    /// <returns>
    ///     <see cref="Dictionary{TKey,TValue}" />
    /// </returns>
    internal static Dictionary<string, List<Dictionary<string, object?>>> ToDictionary(this DataSet dataSet)
    {
        // 空检查
        ArgumentNullException.ThrowIfNull(dataSet);

        return dataSet.Tables.Cast<DataTable>()
            .ToDictionary(table => table.TableName, table => table.ToDictionaryList());
    }
}