using Oson.Domain.Commons;

namespace Oson.Domain.Entities;

public class Transfer:Auditable
{
    public long FromAccountId { get; set; }
    public Account Account { get; set; }
    public long ToAccountId { get; set; }
    public Account Account1 { get; set; }
    public DateTime TransactionDate { get; set; }
    public Decimal Amount { get; set; }
    public long CurrencyId { get; set; }
    public Currency Currency { get; set; }
}
