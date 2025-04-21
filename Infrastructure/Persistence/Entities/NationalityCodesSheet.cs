using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class NationalityCodesSheet
{
    public string? TerritoryShortName { get; set; }

    public string? TerritoryCode { get; set; }
}
