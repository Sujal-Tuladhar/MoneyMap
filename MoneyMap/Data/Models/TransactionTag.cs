namespace MoneyMap.Data.Models;

public class TransactionTag
{
    public Guid TransactionId { get; set; } = Guid.NewGuid();
    
    public Guid TagId { get; set; } = Guid.NewGuid();
    
    
}