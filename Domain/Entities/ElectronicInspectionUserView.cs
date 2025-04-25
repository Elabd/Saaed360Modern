using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ElectronicInspectionUserView
{
    public string UserName { get; set; } = null!;

    public long PersonId { get; set; }
}
