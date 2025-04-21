using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairRequestGarage
{
    public long Id { get; set; }

    public long RepairRequestId { get; set; }

    public int RepairGarageId { get; set; }

    public int RepairStatusId { get; set; }

    public long? LastModifiedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public virtual RepairGarage RepairGarage { get; set; } = null!;

    public virtual RepairQuote? RepairQuote { get; set; }

    public virtual ICollection<RepairRating> RepairRatings { get; set; } = new List<RepairRating>();

    public virtual RepairRequest RepairRequest { get; set; } = null!;

    public virtual ICollection<RepairRequestGarageStatusHistory> RepairRequestGarageStatusHistories { get; set; } = new List<RepairRequestGarageStatusHistory>();

    public virtual ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();

    public virtual RepairStatusDim RepairStatus { get; set; } = null!;
}
