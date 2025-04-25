using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Promotion
{
    public long PromotionId { get; set; }

    public string ReportNumber { get; set; } = null!;

    public string ChassisNumber { get; set; } = null!;

    public string PlateNumber { get; set; } = null!;

    public string OwnerName { get; set; } = null!;

    public string OwnerNumber { get; set; } = null!;

    public DateTime OrderDate { get; set; }
}
