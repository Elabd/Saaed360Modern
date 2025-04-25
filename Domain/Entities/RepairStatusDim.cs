using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RepairStatusDim
{
    public int Id { get; set; }

    public string StatusArabic { get; set; } = null!;

    public string StatusEnglish { get; set; } = null!;

    public string StatusCode { get; set; } = null!;

    public virtual ICollection<RepairRequestGarageStatusHistory> RepairRequestGarageStatusHistoryNewStatusNavigations { get; set; } = new List<RepairRequestGarageStatusHistory>();

    public virtual ICollection<RepairRequestGarageStatusHistory> RepairRequestGarageStatusHistoryOldStatusNavigations { get; set; } = new List<RepairRequestGarageStatusHistory>();

    public virtual ICollection<RepairRequestGarage> RepairRequestGarages { get; set; } = new List<RepairRequestGarage>();

    public virtual ICollection<RepairRequestStatusHistory> RepairRequestStatusHistoryNewStatusNavigations { get; set; } = new List<RepairRequestStatusHistory>();

    public virtual ICollection<RepairRequestStatusHistory> RepairRequestStatusHistoryOldStatusNavigations { get; set; } = new List<RepairRequestStatusHistory>();

    public virtual ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();
}
