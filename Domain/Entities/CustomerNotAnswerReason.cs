using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CustomerNotAnswerReason
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
