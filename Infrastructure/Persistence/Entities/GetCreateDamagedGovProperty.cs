using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetCreateDamagedGovProperty
{
    public long ActivityId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? IntYear { get; set; }

    public long? IntRepEmiCode { get; set; }

    public int? IntRepKindCode { get; set; }

    public string? GovPropertyCode { get; set; }

    public string? GovPropertyOther { get; set; }

    public string? GovAuthorityCode { get; set; }

    public string? GovAuthorityOther { get; set; }
}
