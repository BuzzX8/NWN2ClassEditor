namespace Nwn2.Class
{
    public interface IDataTable
    {
        string Name { get; }

        int ColumnCount { get; }

        int RowCount { get; }

        string this[int rowNumber, string columnName] { get; set; }

        string this[int rowNumber, int columnNumber] { get;set; }
    }
}