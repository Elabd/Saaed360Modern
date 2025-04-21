using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SheetStreet
{
    public string? Emirate { get; set; }

    public string? City { get; set; }

    public string? Sector { get; set; }

    public string? Area { get; set; }

    public string? StreatName { get; set; }

    public int? StreatId { get; set; }

    public int? SectorId { get; set; }
}
