using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairRating
{
    public long Id { get; set; }

    public long RepairRequestGarageId { get; set; }

    public bool IsRated { get; set; }

    public int? ServiceRating { get; set; }

    public int? GarageRating { get; set; }

    public DateTime? RatingDate { get; set; }

    public string? Comment { get; set; }

    public virtual RepairRequestGarage RepairRequestGarage { get; set; } = null!;
}
