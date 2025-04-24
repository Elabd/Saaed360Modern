using Domain.Enums;
using System.Runtime.Serialization;

namespace Application.DTOs.Lookup;

public class AreaDto
{
    public long AreaId { get; set; }
    public string AreaName { get; set; }
    public AreaCategory Category { get; set; }
    public string CategoryName { get; set; }
    public string LocationAddress { get; set; }
    public int? DisplayedOrderIndex { get; set; }
}
