using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewPoliceReport
{
    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public DateTime TransferTime { get; set; }

    public string? OrganizationName { get; set; }

    public string? Description { get; set; }

    public string? TransferedByName { get; set; }

    public string UserName { get; set; } = null!;

    public string? AreaDescription { get; set; }

    public long AreaId { get; set; }

    public string? TransferedByNameNew { get; set; }

    public string? UsernameNew { get; set; }

    public Guid? UserIdNew { get; set; }

    public DateTime? TransferTimeNew { get; set; }

    public string? OrganizationNameNew { get; set; }

    public string? DescriptionNew { get; set; }

    public string? Comment { get; set; }

    public long OrganizationId { get; set; }
}
