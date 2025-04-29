using System.Runtime.Serialization;

namespace Application.DTOs.Lookup;

public class LookupDtoo
{
    public long Id { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public bool InEmirates { get; set; }
}