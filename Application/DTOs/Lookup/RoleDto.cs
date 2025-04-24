namespace Application.DTOs.Lookup;

public class RoleDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public bool IsActive { get; set; }
    public string Description { get; set; }
} 