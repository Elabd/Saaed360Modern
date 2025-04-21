using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AndroidException
{
    public long Id { get; set; }

    public long PatrolId { get; set; }

    public long PersonId { get; set; }

    public string? ClassName { get; set; }

    public string? MethodName { get; set; }

    public string ExceptionMessage { get; set; } = null!;

    public DateTime ExceptionDate { get; set; }

    public DateTime CreationDate { get; set; }
}
