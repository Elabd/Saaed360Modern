using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EmirateDim
{
    public long EmirateId { get; set; }

    public string EmirateName { get; set; } = null!;

    public string? EmirateCode { get; set; }

    public bool IsDefaultForReportConstruction { get; set; }

    public string? EmirateEnglishName { get; set; }

    public string? GoogleMappingName { get; set; }

    public virtual ICollection<AccidentAreaCategorization> AccidentAreaCategorizations { get; set; } = new List<AccidentAreaCategorization>();

    public virtual ICollection<CityDim> CityDims { get; set; } = new List<CityDim>();

    public virtual ICollection<CommissionArea> CommissionAreas { get; set; } = new List<CommissionArea>();

    public virtual ICollection<EmirateArea> EmirateAreas { get; set; } = new List<EmirateArea>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();

    public virtual ICollection<RepairGarage> RepairGarages { get; set; } = new List<RepairGarage>();

    public virtual ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();

    public virtual ICollection<RoadAssistProviderBranch> RoadAssistProviderBranches { get; set; } = new List<RoadAssistProviderBranch>();

    public virtual ICollection<RoadAssistProvider> RoadAssistProviders { get; set; } = new List<RoadAssistProvider>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequestServiceDeliveryDistinationEmirates { get; set; } = new List<RoadAssistRequest>();

    public virtual ICollection<RoadAssistRequest> RoadAssistRequestServiceDeliveryLocationEmirates { get; set; } = new List<RoadAssistRequest>();

    public virtual ICollection<RoadAssistServicePriceByEmirate> RoadAssistServicePriceByEmirates { get; set; } = new List<RoadAssistServicePriceByEmirate>();

    public virtual SmartDispatchingEmirateConfiguration? SmartDispatchingEmirateConfiguration { get; set; }
}
