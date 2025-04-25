using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NationalityDim
{
    public int NationalityId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual ICollection<EventIncidentPerson> EventIncidentPeople { get; set; } = new List<EventIncidentPerson>();

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();

    public virtual ICollection<OwnerDatum> OwnerData { get; set; } = new List<OwnerDatum>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspDriverDatum> RspDriverData { get; set; } = new List<RspDriverDatum>();

    public virtual ICollection<Wittness> Wittnesses { get; set; } = new List<Wittness>();
}
