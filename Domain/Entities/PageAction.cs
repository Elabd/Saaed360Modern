using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PageAction
{
    public Guid Id { get; set; }

    public string ControlDisplayName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ControlUniqueName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public long PageId { get; set; }

    public bool InsideControl { get; set; }

    public string? ParentUniqeName { get; set; }

    public string? ParentControlType { get; set; }

    public int? PageActionCategoryId { get; set; }

    public virtual ApplicationPage Page { get; set; } = null!;

    public virtual PageActionCategoryDim? PageActionCategory { get; set; }

    public virtual ICollection<PageActionRole> PageActionRoles { get; set; } = new List<PageActionRole>();
}
