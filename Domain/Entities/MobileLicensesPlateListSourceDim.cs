using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileLicensesPlateListSourceDim
{
    public int LicensePlateListSourceId { get; set; }

    public string? Description { get; set; }

    public string? DescriptionEn { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool InEmirates { get; set; }
}

