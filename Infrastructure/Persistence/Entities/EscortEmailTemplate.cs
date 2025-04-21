using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EscortEmailTemplate
{
    public int EscortEmailTemplateId { get; set; }

    public string? Template { get; set; }

    public string? Name { get; set; }

    public string? EmailTitle { get; set; }
}

