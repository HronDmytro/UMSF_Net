public class SqlQueryBuilder
{
    private string _select;
    private string _where;
    private string _orderBy;

    public SqlQueryBuilder Select(string fields) { _select = $"SELECT {fields}"; return this; }
    public SqlQueryBuilder Where(string condition) { _where = $"WHERE {condition}"; return this; }
    public SqlQueryBuilder OrderBy(string column) { _orderBy = $"ORDER BY {column}"; return this; }

    public string Build() => $"{_select} FROM Table {_where} {_orderBy}".Trim();
}
