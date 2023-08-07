using Oson.Domain.Commons;

namespace Oson.Domain.Entities;

public class CardTransaction:Auditable
{
    public long CardId { get; set; }
    public Card Card { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public long TrasnactionTypeId { get; set; }
    public TransactionType TransactionType { get; set; }
    public string Description { get; set; }
}
