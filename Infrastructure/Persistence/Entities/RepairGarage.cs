using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairGarage
{
    public int Id { get; set; }

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string AddressArabic { get; set; } = null!;

    public string AddressEnglish { get; set; } = null!;

    public long EmirateDimId { get; set; }

    public long AreaId { get; set; }

    public decimal? LocationLongitude { get; set; }

    public decimal? LocationLatitude { get; set; }

    public bool IsDeleted { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? CommunicationLanguage { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual EmirateDim EmirateDim { get; set; } = null!;

    public virtual ICollection<RepairGaragePerson> RepairGaragePeople { get; set; } = new List<RepairGaragePerson>();

    public virtual ICollection<RepairRequestGarage> RepairRequestGarages { get; set; } = new List<RepairRequestGarage>();
}
