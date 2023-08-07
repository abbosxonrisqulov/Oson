using Oson.Domain.Commons;

namespace Oson.Domain.Entities;

public class AccountType:Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}
