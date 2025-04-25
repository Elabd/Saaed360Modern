using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonNationality
{
    public long PersonNationalityId { get; set; }

    public long? PersonId { get; set; }

    public int? NationalityId { get; set; }

    public string? Username { get; set; }

    public bool? IsEmirate { get; set; }

    public Guid? UserId { get; set; }

    public string? NationalityDescription { get; set; }

    public string? NationalityCode { get; set; }

    public virtual Person? Person { get; set; }
}
