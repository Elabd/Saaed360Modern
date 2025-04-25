using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VUploadAccidentCauseDatum
{
    public long ActivityId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? IntYear { get; set; }

    public long? IntRepEmiCode { get; set; }

    public int? IntRepKindCode { get; set; }

    public int IntVehNo { get; set; }

    public string StrMainCause { get; set; } = null!;

    public int? IntAccCode { get; set; }

    public string? StrVehDrawBack { get; set; }

    public string? StrStDrawBack { get; set; }

    public string? StrOtherDrawBack { get; set; }

    public int? VehicleDataId { get; set; }

    public long? CreatedBy { get; set; }
}
