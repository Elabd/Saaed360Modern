using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileIncidentTypeDim
{
    public int MobileIncidentTypeId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool Isdeleted { get; set; }

    public int? Code { get; set; }
}
