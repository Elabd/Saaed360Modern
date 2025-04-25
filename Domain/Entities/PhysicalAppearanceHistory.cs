using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PhysicalAppearanceHistory
{
    public long PhysicalAppearanceHistoryId { get; set; }

    public Guid PhysicalAppearanceHistoryGuid { get; set; }

    public string PhysicalAppearanceHistoryDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public string? HeightFeet { get; set; }

    public string? HeightInches { get; set; }

    public string? Weight { get; set; }

    public int? PersonBuildId { get; set; }

    public int? PersonSkinToneId { get; set; }

    public int? PersonHairColorId { get; set; }

    public int? PersonRightEyeColorId { get; set; }

    public int? PersonLeftEyeColorId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonBuildDim? PersonBuild { get; set; }

    public virtual PersonHairColorDim? PersonHairColor { get; set; }

    public virtual PersonEyeColorDim? PersonLeftEyeColor { get; set; }

    public virtual PersonEyeColorDim? PersonRightEyeColor { get; set; }

    public virtual PersonSkinToneDim? PersonSkinTone { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
