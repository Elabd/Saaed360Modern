using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PageActionRole
{
    public Guid RoleId { get; set; }

    public Guid ActionId { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime? CreationDate { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public Guid? ModifiedBy { get; set; }

    public virtual PageAction Action { get; set; } = null!;

    public virtual AspnetRole Role { get; set; } = null!;
}
