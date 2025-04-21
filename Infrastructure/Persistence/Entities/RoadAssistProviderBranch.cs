using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistProviderBranch
{
    public Guid BranchId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public Guid ProviderId { get; set; }

    public string? AddressEn { get; set; }

    public string? AddressAr { get; set; }

    public decimal? LocationLong { get; set; }

    public decimal? LocationLat { get; set; }

    public long EmirateId { get; set; }

    public string? BeneficiaryCode { get; set; }

    public string? BeneficiaryVatCode { get; set; }

    public string? BranchNameEn { get; set; }

    public string? BranchNameAr { get; set; }

    public string? EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual EmirateDim Emirate { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistProvider Provider { get; set; } = null!;

    public virtual ICollection<RoadAssistFuelFeesPerUnit> RoadAssistFuelFeesPerUnits { get; set; } = new List<RoadAssistFuelFeesPerUnit>();

    public virtual ICollection<RoadAssistProviderService> RoadAssistProviderServices { get; set; } = new List<RoadAssistProviderService>();

    public virtual ICollection<RoadAssistProviderVehicle> RoadAssistProviderVehicles { get; set; } = new List<RoadAssistProviderVehicle>();

    public virtual ICollection<RoadAssistRequestStatusLog> RoadAssistRequestStatusLogs { get; set; } = new List<RoadAssistRequestStatusLog>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();

    public virtual ICollection<RoadAssistRider> RoadAssistRiders { get; set; } = new List<RoadAssistRider>();
}
