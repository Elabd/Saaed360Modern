using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VUploadAccidentDamagedGov
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

    public int? ImpactLevelId { get; set; }

    public int? ImpactTypeId { get; set; }

    public long? CreatedBy { get; set; }
}
