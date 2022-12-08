using System;
namespace StockList.Models;
    
public class StockListDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string StockCollectionName { get; set; } = null!;
}
