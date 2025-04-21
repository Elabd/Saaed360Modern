using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewObjectionDocument
{
    public string DocName { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string PersonName { get; set; } = null!;

    public long ObjectionId { get; set; }
}
