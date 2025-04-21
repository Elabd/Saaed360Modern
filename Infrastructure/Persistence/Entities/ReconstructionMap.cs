using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReconstructionMap
{
    public int ReconstructionMapId { get; set; }

    public double? ZoomTickFrequency { get; set; }

    public double? LatitudeValue { get; set; }

    public double? LongitudeValue { get; set; }

    public double? ZoomLevel { get; set; }

    public bool? IsDeleted { get; set; }

    public string? MapMode { get; set; }

    public string? CurrentLocationValue { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? SearchAddress { get; set; }

    public long? SelectedMapTypeId { get; set; }

    public string? SelectedMap { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<ReconstructionGraph> ReconstructionGraphs { get; set; } = new List<ReconstructionGraph>();

    public virtual ICollection<ReportReconstructionPlan> ReportReconstructionPlans { get; set; } = new List<ReportReconstructionPlan>();
}
