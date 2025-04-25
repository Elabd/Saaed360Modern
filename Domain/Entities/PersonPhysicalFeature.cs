using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonPhysicalFeature
{
    public long PersonPhysicalFeatureId { get; set; }

    public Guid PersonPhysicalFeatureGuid { get; set; }

    public string PersonPhysicalFeatureDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public long? PhysicalFeatureImageId { get; set; }

    public Guid PhysicalFeatureImageGuid { get; set; }

    public int? PhysicalFeatureCategoryId { get; set; }

    public int? PhysicalFeatureLocationId { get; set; }

    public string? PhysicalFeatureDescription { get; set; }

    public int? PhysicalFeatureSeverityId { get; set; }

    public int? PhysicalFeatureHandicapId { get; set; }

    public DateTime? RemovedDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PhysicalFeatureCategoryDim? PhysicalFeatureCategory { get; set; }

    public virtual PhysicalFeatureHandicapDim? PhysicalFeatureHandicap { get; set; }

    public virtual Image? PhysicalFeatureImage { get; set; }

    public virtual PhysicalFeatureLocationDim? PhysicalFeatureLocation { get; set; }

    public virtual PhysicalFeatureSeverityDim? PhysicalFeatureSeverity { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
