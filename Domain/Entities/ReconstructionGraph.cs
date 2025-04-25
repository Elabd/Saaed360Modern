using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReconstructionGraph
{
    public int ReconstructionGraphId { get; set; }

    public double? Height { get; set; }

    public double? Width { get; set; }

    public double? RotateValue { get; set; }

    public double? Xaxis { get; set; }

    public double? Yaxis { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ImagePath { get; set; }

    public Guid? CurrentId { get; set; }

    public int ReconstructionMapId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? ImageName { get; set; }

    public double? M11 { get; set; }

    public double? M12 { get; set; }

    public double? M21 { get; set; }

    public double? M22 { get; set; }

    public double? OffsetX { get; set; }

    public double? OffsetY { get; set; }

    public bool? IsTouchedDown { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ReconstructionMap ReconstructionMap { get; set; } = null!;
}
