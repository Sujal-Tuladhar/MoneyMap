using System.Runtime.InteropServices.JavaScript;


namespace MoneyMap.Data.Models;

public class Debt
{
    public Guid DebtID { get; set; } = Guid.NewGuid();
    
    public Guid TransactionID { get; set; }
    
    public string source { get; set; }
    
    public JSType.Date dueDate { get; set; }
    
    public bool Status { get; set; }
}