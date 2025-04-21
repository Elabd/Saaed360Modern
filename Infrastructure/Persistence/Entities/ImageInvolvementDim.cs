using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImageInvolvementDim
{
    public int ImageInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ActivityImage> ActivityImages { get; set; } = new List<ActivityImage>();

    public virtual ICollection<ItemImage> ItemImages { get; set; } = new List<ItemImage>();

    public virtual ICollection<LocationImage> LocationImages { get; set; } = new List<LocationImage>();

    public virtual ICollection<OrganizationImage> OrganizationImages { get; set; } = new List<OrganizationImage>();

    public virtual ICollection<PersonImage> PersonImages { get; set; } = new List<PersonImage>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
