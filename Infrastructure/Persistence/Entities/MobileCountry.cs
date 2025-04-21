using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileCountry
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public string CountryNameAr { get; set; } = null!;

    public string CountryCode { get; set; } = null!;
}
