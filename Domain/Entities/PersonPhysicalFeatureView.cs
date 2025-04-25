using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonPhysicalFeatureView
{
    public long PersonPhysicalFeatureId { get; set; }

    public string PersonPhysicalFeatureDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long? PhysicalFeatureImageId { get; set; }

    public string? PhysicalFeatureCategoryCode { get; set; }

    public string? PhysicalFeatureCategoryDescription { get; set; }

    public string? PhysicalFeatureLocationCode { get; set; }

    public string? PhysicalFeatureLocationDescription { get; set; }

    public string? PhysicalFeatureDescription { get; set; }

    public string? PhysicalFeatureSeverityCode { get; set; }

    public string? PhysicalFeatureSeverityDescription { get; set; }

    public string? PhysicalFeatureHandicapCode { get; set; }

    public string? PhysicalFeatureHandicapDescription { get; set; }

    public DateTime? RemovedDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
