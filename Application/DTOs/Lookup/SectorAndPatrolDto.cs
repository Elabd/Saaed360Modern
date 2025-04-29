using Saaed360Modern.Contracts.Wcf;

namespace Application.DTOs.Lookup;

public class SectorAndPatrolDto
{
    public List<LookupDto> Sectors { get; set; }
    public List<LookupDto> Patrols { get; set; }
} 