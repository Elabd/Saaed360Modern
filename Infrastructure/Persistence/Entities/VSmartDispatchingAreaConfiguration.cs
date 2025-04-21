using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VSmartDispatchingAreaConfiguration
{
    public long AreaId { get; set; }

    public string? Area { get; set; }

    public long? EmirateId { get; set; }

    public string? EmirateNameArabic { get; set; }

    public string? EmirateNameEnglish { get; set; }

    public int? RuralAreaTime { get; set; }

    public int? UrbanAreaTime { get; set; }

    public int? DesertAreaTime { get; set; }

    public int? DefaultTime { get; set; }

    public bool? IsEnabled { get; set; }
}
