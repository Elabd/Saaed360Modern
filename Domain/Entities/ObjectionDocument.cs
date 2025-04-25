using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionDocument
{
    public long ObjectionDocId { get; set; }

    public long ObjectionId { get; set; }

    public long PersonId { get; set; }

    public DateTime CreationTime { get; set; }

    public string DocPath { get; set; } = null!;
}
