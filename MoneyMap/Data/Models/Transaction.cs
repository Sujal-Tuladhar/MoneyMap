using System.Runtime.InteropServices.JavaScript;

namespace MoneyMap.Data.Models;

public class Transaction
{
    public Guid TransactionID { get; set; } = Guid.NewGuid();

    public string Title { get; set; }
    
    public string Type { get; set; }
    
    public float Amount { get; set; }
    
    public string Note { get; set; }
    
    public JSType.Date Date { get; set; }
}