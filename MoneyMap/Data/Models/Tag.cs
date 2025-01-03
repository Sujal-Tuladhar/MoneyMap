namespace MoneyMap.Data.Models;

public class Tag
{
    public Guid TagID { get; set; } = Guid.NewGuid();
    
    public string TagName { get; set; }
}