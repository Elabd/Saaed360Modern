using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VwUserLoginLastActivity
{
    public long ActivityId { get; set; }

    public string? Code { get; set; }

    public long? PersonId { get; set; }

    public long? AreaId { get; set; }

    public long? Organizationid { get; set; }
}
