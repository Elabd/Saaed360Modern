using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PhysicalAppearanceHistoryGuidView
{
    public Guid PhysicalAppearanceHistoryGuid { get; set; }

    public string PhysicalAppearanceHistoryDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? HeightFeet { get; set; }

    public string? HeightInches { get; set; }

    public string? Weight { get; set; }

    public string? PersonBuildCode { get; set; }

    public string? PersonSkinToneCode { get; set; }

    public string? PersonHairColorCode { get; set; }

    public string? PersonRightEyeColorCode { get; set; }

    public string? PersonLeftEyeColorCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
