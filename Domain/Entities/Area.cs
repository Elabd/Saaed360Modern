using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Area
{
    public long AreaId { get; set; }

    public Guid AreaGuid { get; set; }

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long SourceId { get; set; }

    public int? AreaCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Coordinates { get; set; }

    public string? AreaDescription { get; set; }

    public int? DisplayedOrderIndex { get; set; }

    public virtual ICollection<ActivityArea> ActivityAreas { get; set; } = new List<ActivityArea>();

    public virtual ICollection<AreaAssociation> AreaAssociationAreas { get; set; } = new List<AreaAssociation>();

    public virtual ICollection<AreaAssociation> AreaAssociationRelatedAreas { get; set; } = new List<AreaAssociation>();

    public virtual AreaCategoryDim? AreaCategory { get; set; }

    public virtual ICollection<AreaItem1> AreaItem1s { get; set; } = new List<AreaItem1>();

    public virtual ICollection<AreaItem> AreaItems { get; set; } = new List<AreaItem>();

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<EmirateArea> EmirateAreas { get; set; } = new List<EmirateArea>();

    public virtual ICollection<EventsPatrol> EventsPatrolAreas { get; set; } = new List<EventsPatrol>();

    public virtual ICollection<EventsPatrol> EventsPatrolSectors { get; set; } = new List<EventsPatrol>();

    public virtual ICollection<IcccincidentRequestDetail> IcccincidentRequestDetails { get; set; } = new List<IcccincidentRequestDetail>();

    public virtual ICollection<LocationArea> LocationAreas { get; set; } = new List<LocationArea>();

    public virtual ICollection<LocationMatrix> LocationMatrixAreas { get; set; } = new List<LocationMatrix>();

    public virtual ICollection<LocationMatrix> LocationMatrixCities { get; set; } = new List<LocationMatrix>();

    public virtual ICollection<LocationMatrix> LocationMatrixEmirates { get; set; } = new List<LocationMatrix>();

    public virtual ICollection<LocationMatrix> LocationMatrixSectors { get; set; } = new List<LocationMatrix>();

    public virtual ICollection<LocationMatrix> LocationMatrixStreets { get; set; } = new List<LocationMatrix>();

    public virtual ICollection<LogedInPatrol> LogedInPatrols { get; set; } = new List<LogedInPatrol>();

    public virtual ICollection<MobileRequest> MobileRequests { get; set; } = new List<MobileRequest>();

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual ICollection<PersonArea> PersonAreas { get; set; } = new List<PersonArea>();

    public virtual ICollection<RepairGarage> RepairGarages { get; set; } = new List<RepairGarage>();

    public virtual ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SmartDispatchingAreaConfiguration? SmartDispatchingAreaConfiguration { get; set; }

    public virtual Source Source { get; set; } = null!;
}
