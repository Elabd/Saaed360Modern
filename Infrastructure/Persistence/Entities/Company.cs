using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Company
{
    public long CompanyId { get; set; }

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string? Tcn { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? TaxRegistrationNumber { get; set; }

    public string? RepresentativeName { get; set; }

    public string? RepresentativePhone { get; set; }

    public string? RepresentativeEmail { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? ModifictionDateTime { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? Balance { get; set; }

    public virtual ICollection<CompanyAttachment> CompanyAttachments { get; set; } = new List<CompanyAttachment>();

    public virtual CompanyPatrolsBalance? CompanyPatrolsBalance { get; set; }

    public virtual ICollection<CompanyPatrolsBalanceLog> CompanyPatrolsBalanceLogs { get; set; } = new List<CompanyPatrolsBalanceLog>();

    public virtual ICollection<CompanyUser> CompanyUsers { get; set; } = new List<CompanyUser>();

    public virtual ICollection<CompanyVehicle> CompanyVehicles { get; set; } = new List<CompanyVehicle>();

    public virtual ICollection<Escort> Escorts { get; set; } = new List<Escort>();
}
