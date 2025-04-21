namespace Infrastructure.Persistence.Entities;

public partial class YearDim
{
    public int YearId { get; set; }
    public string Description { get; set; }
    public System.DateTime VersionDateTime { get; set; }
    public int? RowStatusId { get; set; }
    public bool? IsDeleted { get; set; }
    public byte[] TimeStamp { get; set; }
}