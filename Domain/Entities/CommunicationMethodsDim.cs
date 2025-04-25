using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CommunicationMethodsDim
{
    public int CommunicationMethodId { get; set; }

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();

    public virtual ICollection<Objection> Objections { get; set; } = new List<Objection>();
}
