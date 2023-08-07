using Oson.Domain.Commons;

namespace Oson.Domain.Entities;

public class Card:Auditable
{
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
    public string CardNumber { get; set; }
    public string CardType { get; set; }
    public DateTime ExpireDate { get; set; }
    public int? CVV { get; set; }
}
