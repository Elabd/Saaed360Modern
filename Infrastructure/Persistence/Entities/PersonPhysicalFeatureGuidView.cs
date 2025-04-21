using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonPhysicalFeatureGuidView
{
    public Guid PersonPhysicalFeatureGuid { get; set; }

    public string PersonPhysicalFeatureDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid PhysicalFeatureImageGuid { get; set; }

    public string? PhysicalFeatureCategoryCode { get; set; }

    public string? PhysicalFeatureLocationCode { get; set; }

    public string? PhysicalFeatureDescription { get; set; }

    public string? PhysicalFeatureSeverityCode { get; set; }

    public string? PhysicalFeatureHandicapCode { get; set; }

    public DateTime? RemovedDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
