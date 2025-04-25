using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FacilityBedAssignmentDimcodeView
{
    public string FacilityBedAssignmentCode { get; set; } = null!;

    public string? FacilityBedAssignmentBuilding { get; set; }

    public string? FacilityBedAssignmentBlock { get; set; }

    public string? FacilityBedAssignmentCell { get; set; }

    public string? FacilityBedAssignmentBed { get; set; }

    public string? FacilityBedAssignmentDescription { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
