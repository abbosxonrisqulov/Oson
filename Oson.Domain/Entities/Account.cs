using Oson.Domain.Commons;

namespace Oson.Domain.Entities;

public class Account :Auditable
{
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
    public decimal Balance { get; set; }
    public long AccountTypeId { get; set; }
    public AccountType AccountType { get; set; }
    public DateTime OpenDate { get; set; }
    public string Status { get; set; }
}
