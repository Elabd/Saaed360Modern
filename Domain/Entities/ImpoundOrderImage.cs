using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundOrderImage
{
    public long Id { get; set; }

    public long ImpoundOrderId { get; set; }

    public long ImageId { get; set; }

    public bool IsDeleted { get; set; }
}
