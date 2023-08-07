using Oson.Domain.Commons;

namespace Oson.Domain.Entities;

public class Transaction:Auditable
{
    public long Accountid { get; set; }
    public Account Account { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public long TransactionTypeId { get; set; }
    public TransactionType TransactionType { get; set; }

}
