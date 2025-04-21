using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VwTransportersSaaed
{
    public Guid TransporterId { get; set; }

    public string? Code { get; set; }

    public string? FullPlateNumber { get; set; }

    public string? PlateNoColor { get; set; }

    public string? PlateNoNumbers { get; set; }

    public string? BranchName { get; set; }

    public Guid? BranchId { get; set; }

    public Guid? ParentBranchId { get; set; }

    public string? ParentBranchName { get; set; }

    public string? ChassisNumber { get; set; }

    public string? Category { get; set; }

    public string? Type { get; set; }

    public string? TransporterBrand { get; set; }

    public string? TransporterModel { get; set; }

    public string? ProductionYear { get; set; }

    public double? SpeedLimit { get; set; }

    public double? CurrentMileage { get; set; }

    public string? TransporterStatusName { get; set; }
}
