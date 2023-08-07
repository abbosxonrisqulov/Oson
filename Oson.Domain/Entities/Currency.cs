using Oson.Domain.Commons;

namespace Oson.Domain.Entities;

public class Currency:Auditable
{
    public string Name { get; set; }
    public int Code { get; set; }
}
