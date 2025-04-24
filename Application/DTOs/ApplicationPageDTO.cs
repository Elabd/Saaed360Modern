namespace Application.DTOs;

public class ApplicationPageDTO
{
    public long Id { get; set; }
    public string PageName { get; set; }
    public string IconPath { get; set; }
    public string Url { get; set; }
    public bool IsAdmin { get; set; }
} 