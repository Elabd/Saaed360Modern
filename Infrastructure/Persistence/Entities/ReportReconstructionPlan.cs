using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportReconstructionPlan
{
    public int ReportReconstructionPlanId { get; set; }

    public int ReportId { get; set; }

    public int ReconstructionMapId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? ReconstructionCapture { get; set; }

    public bool Ismodified { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ReconstructionMap ReconstructionMap { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;
}
