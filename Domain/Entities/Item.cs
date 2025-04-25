using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Item
{
    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? ItemCategoryId { get; set; }

    public int? ItemStatusId { get; set; }

    public int? ItemMakeModelId { get; set; }

    public int? ModelYear { get; set; }

    public int? ItemPrimaryColorId { get; set; }

    public int? ItemSecondaryColorId { get; set; }

    public int? ItemConditionId { get; set; }

    public int? ItemUsageId { get; set; }

    public string? ItemName { get; set; }

    public string? Description { get; set; }

    public string? SerialIdentification { get; set; }

    public double? ItemValue { get; set; }

    public string? SizeDescription { get; set; }

    public double? HeightMeasure { get; set; }

    public double? LengthMeasure { get; set; }

    public double? WidthMeasure { get; set; }

    public double? WeightMeasure { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? ItemManufactoryId { get; set; }

    public string? TrackerCode { get; set; }

    public string? DeviceCodeSimCard { get; set; }

    public string? TrackerSimCard { get; set; }

    public string? DeviceCode { get; set; }

    public virtual ICollection<ActivityItem> ActivityItems { get; set; } = new List<ActivityItem>();

    public virtual ICollection<ActivityTransaction> ActivityTransactions { get; set; } = new List<ActivityTransaction>();

    public virtual Aircraft? Aircraft { get; set; }

    public virtual ICollection<AreaItem1> AreaItem1s { get; set; } = new List<AreaItem1>();

    public virtual ICollection<AreaItem> AreaItems { get; set; } = new List<AreaItem>();

    public virtual Article? Article { get; set; }

    public virtual ICollection<CaseExhibitEvidence> CaseExhibitEvidences { get; set; } = new List<CaseExhibitEvidence>();

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<DamagedProperty> DamagedProperties { get; set; } = new List<DamagedProperty>();

    public virtual Drug? Drug { get; set; }

    public virtual ICollection<EscortMissionPatrol> EscortMissionPatrols { get; set; } = new List<EscortMissionPatrol>();

    public virtual ICollection<EventsPatrol> EventsPatrols { get; set; } = new List<EventsPatrol>();

    public virtual Evidence? Evidence { get; set; }

    public virtual Firearm? Firearm { get; set; }

    public virtual ICollection<IcccincidentLog> IcccincidentLogs { get; set; } = new List<IcccincidentLog>();

    public virtual ICollection<ItemAlias> ItemAliases { get; set; } = new List<ItemAlias>();

    public virtual ItemCategoryDim? ItemCategory { get; set; }

    public virtual ICollection<ItemComment> ItemComments { get; set; } = new List<ItemComment>();

    public virtual ItemConditionDim? ItemCondition { get; set; }

    public virtual ICollection<ItemDocument> ItemDocuments { get; set; } = new List<ItemDocument>();

    public virtual ICollection<ItemIdentifier> ItemIdentifiers { get; set; } = new List<ItemIdentifier>();

    public virtual ICollection<ItemImage> ItemImages { get; set; } = new List<ItemImage>();

    public virtual ICollection<ItemLocation> ItemLocations { get; set; } = new List<ItemLocation>();

    public virtual ItemMakeModelDim? ItemMakeModel { get; set; }

    public virtual ItemManufactoryDim? ItemManufactory { get; set; }

    public virtual ItemColorDim? ItemPrimaryColor { get; set; }

    public virtual ICollection<ItemRegistration> ItemRegistrations { get; set; } = new List<ItemRegistration>();

    public virtual ItemColorDim? ItemSecondaryColor { get; set; }

    public virtual ItemStatusDim? ItemStatus { get; set; }

    public virtual ItemUsageDim? ItemUsage { get; set; }

    public virtual Jewelry? Jewelry { get; set; }

    public virtual ICollection<JewelryStone> JewelryStones { get; set; } = new List<JewelryStone>();

    public virtual LicensePlate? LicensePlate { get; set; }

    public virtual ICollection<LogedInPatrol> LogedInPatrols { get; set; } = new List<LogedInPatrol>();

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<OrganizationItem> OrganizationItems { get; set; } = new List<OrganizationItem>();

    public virtual ICollection<OrganizationUnitLog> OrganizationUnitLogs { get; set; } = new List<OrganizationUnitLog>();

    public virtual ICollection<PersonItem> PersonItems { get; set; } = new List<PersonItem>();

    public virtual Realestate? Realestate { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SmartDispatchingIncidentStatusLog> SmartDispatchingIncidentStatusLogs { get; set; } = new List<SmartDispatchingIncidentStatusLog>();

    public virtual ICollection<SmartDispatchingReturnToOperationRoomLog> SmartDispatchingReturnToOperationRoomLogs { get; set; } = new List<SmartDispatchingReturnToOperationRoomLog>();

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

    public virtual Vehicle? Vehicle { get; set; }

    public virtual Vessel? Vessel { get; set; }
}
