namespace Application.DTOs.Lookup;

public class VersionsDto
{
    public string VersionNumber { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public string Description { get; set; } = string.Empty;
} 