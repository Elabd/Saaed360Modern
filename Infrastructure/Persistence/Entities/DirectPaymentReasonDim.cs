using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DirectPaymentReasonDim
{
    public int DirectPaymentReasonId { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public virtual ICollection<DirectPaymentTransaction> DirectPaymentTransactions { get; set; } = new List<DirectPaymentTransaction>();
}
