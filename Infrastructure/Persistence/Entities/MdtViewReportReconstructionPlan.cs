using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtViewReportReconstructionPlan
{
    public int ReportId { get; set; }

    public int ReconstructionMapId { get; set; }

    public double? ZoomTickFrequency { get; set; }

    public double? LatitudeValue { get; set; }

    public double? LongitudeValue { get; set; }

    public double? ZoomLevel { get; set; }

    public string? MapMode { get; set; }

    public string? CurrentLocationValue { get; set; }

    public int ReconstructionGraphId { get; set; }

    public string? SearchAddress { get; set; }

    public double? Height { get; set; }

    public double? Width { get; set; }

    public double? RotateValue { get; set; }

    public double? Xaxis { get; set; }

    public double? Yaxis { get; set; }

    public string? ImagePath { get; set; }

    public Guid? CurrentId { get; set; }

    public string? ImageName { get; set; }

    public double? M11 { get; set; }

    public double? M12 { get; set; }

    public double? M21 { get; set; }

    public double? M22 { get; set; }

    public double? OffsetX { get; set; }

    public double? OffsetY { get; set; }

    public bool? IsTouchedDown { get; set; }

    public long? SelectedMapTypeId { get; set; }

    public string? SelectedMap { get; set; }
}
