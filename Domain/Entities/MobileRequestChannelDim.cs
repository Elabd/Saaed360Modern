using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileRequestChannelDim
{
    public int? ChannelId { get; set; }

    public string? ChannelDesc { get; set; }

    public int? OrganizationId { get; set; }

    public string? OrganizationDesc { get; set; }
}
