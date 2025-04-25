using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistProvider
{
    public Guid ProviderId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string ProviderNameEn { get; set; } = null!;

    public string ProviderNameAr { get; set; } = null!;

    public long EmirateId { get; set; }

    public string AddressEn { get; set; } = null!;

    public string AddressAr { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public decimal? LocationLong { get; set; }

    public decimal? LocationLat { get; set; }

    public string? LogoImage { get; set; }

    public string? EmailAddress { get; set; }

    public string? BeneficiaryCode { get; set; }

    public string? BeneficiaryVatCode { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual EmirateDim Emirate { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual ICollection<RoadAssistFuelFeesPerUnit> RoadAssistFuelFeesPerUnits { get; set; } = new List<RoadAssistFuelFeesPerUnit>();

    public virtual ICollection<RoadAssistProviderBranch> RoadAssistProviderBranches { get; set; } = new List<RoadAssistProviderBranch>();

    public virtual ICollection<RoadAssistProviderPerson> RoadAssistProviderPeople { get; set; } = new List<RoadAssistProviderPerson>();

    public virtual ICollection<RoadAssistProviderService> RoadAssistProviderServices { get; set; } = new List<RoadAssistProviderService>();

    public virtual ICollection<RoadAssistRequestStatusLog> RoadAssistRequestStatusLogs { get; set; } = new List<RoadAssistRequestStatusLog>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequests { get; set; } = new List<RoadAssistRequest>();

    public virtual ICollection<RoadAssistRider> RoadAssistRiders { get; set; } = new List<RoadAssistRider>();
}
