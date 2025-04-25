using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityReasonDim
{
    public int ActivityReasonId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? ReasonCategoryId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityConvertToStationArc> ActivityConvertToStationArcs { get; set; } = new List<ActivityConvertToStationArc>();

    public virtual ICollection<ActivityConvertToStation> ActivityConvertToStations { get; set; } = new List<ActivityConvertToStation>();

    public virtual ICollection<MobileRequestRejectionReasonDim> MobileRequestRejectionReasonDims { get; set; } = new List<MobileRequestRejectionReasonDim>();

    public virtual ICollection<MobileStatusMessagesDim> MobileStatusMessagesDims { get; set; } = new List<MobileStatusMessagesDim>();

    public virtual ICollection<Objection> Objections { get; set; } = new List<Objection>();

    public virtual ICollection<OrganizationReason> OrganizationReasons { get; set; } = new List<OrganizationReason>();

    public virtual ReasonCategoryDim? ReasonCategory { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
