using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FieldsFactorDim
{
    public long FieldsFactorId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? IsActive { get; set; }
}
