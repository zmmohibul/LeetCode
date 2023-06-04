namespace DesignSQL;

public class SQL 
{
    private Dictionary<string, RowItems> Table { get; set; }
    
    public SQL(IList<string> names, IList<int> columns)
    {
        Table = new Dictionary<string, RowItems>();
        foreach (var name in names)
        {
            Table[name] = new RowItems();
        }
    }
    
    public void InsertRow(string name, IList<string> row) 
    {
        Table[name].Insert(row);
    }
    
    public void DeleteRow(string name, int rowId) 
    {
        Table[name].Delete(rowId);
    }
    
    public string SelectCell(string name, int rowId, int columnId)
    {
        return Table[name].Get(rowId, columnId);
    }
}

public class RowItems
{
    private int Id { get; set; } = 0;
    private Dictionary<int, IList<string>> Row { get; set; }

    public RowItems()
    {
        Row = new Dictionary<int, IList<string>>();
    }

    public void Insert(IList<string> row)
    {
        Row[Id] = row;
        Id += 1;
    }

    public void Delete(int id)
    {
        Row.Remove(id);
    }

    public string Get(int rowId, int columnId)
    {
        return Row[rowId][columnId];
    }
}