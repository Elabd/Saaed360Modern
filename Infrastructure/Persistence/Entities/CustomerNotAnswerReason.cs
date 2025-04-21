using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CustomerNotAnswerReason
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
