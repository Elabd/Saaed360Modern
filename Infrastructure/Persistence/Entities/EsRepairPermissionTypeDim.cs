using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EsRepairPermissionTypeDim
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string NameUrdu { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();
}
