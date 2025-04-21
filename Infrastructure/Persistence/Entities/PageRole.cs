using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PageRole
{
    public Guid PageRoleId { get; set; }

    public Guid RoleId { get; set; }

    public long PageId { get; set; }

    public short AccessType { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreationDate { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual AcessTypeDim AccessTypeNavigation { get; set; } = null!;

    public virtual ApplicationPage Page { get; set; } = null!;

    public virtual AspnetRole Role { get; set; } = null!;
}
