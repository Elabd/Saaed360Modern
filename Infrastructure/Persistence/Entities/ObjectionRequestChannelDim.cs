using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ObjectionRequestChannelDim
{
    public int ChannelId { get; set; }

    public string? ChannelDesc { get; set; }

    public string? ChannelArDesc { get; set; }

    public int? OrganizationId { get; set; }

    public string? OrganizationDesc { get; set; }

    public string? AfterPaymentReturnUrl { get; set; }

    public virtual ICollection<Objection> Objections { get; set; } = new List<Objection>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();
}
