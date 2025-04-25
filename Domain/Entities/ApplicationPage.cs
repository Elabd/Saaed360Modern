using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ApplicationPage
{
    public long Id { get; set; }

    public string? PageName { get; set; }

    public string? Description { get; set; }

    public string? Name { get; set; }

    public bool? IsDefault { get; set; }

    public bool? NeedPermissions { get; set; }

    public bool? Visible { get; set; }

    public string? IconPath { get; set; }

    public string? ViewModelName { get; set; }

    public int? ApplicationPagesCategoryId { get; set; }

    public string? Url { get; set; }

    public bool? IsAdmin { get; set; }

    public virtual ApplicationPagesCategoryDim? ApplicationPagesCategory { get; set; }

    public virtual ICollection<AspnetRole> AspnetRoles { get; set; } = new List<AspnetRole>();

    public virtual ICollection<PageAction> PageActions { get; set; } = new List<PageAction>();

    public virtual ICollection<PageRole> PageRoles { get; set; } = new List<PageRole>();
}
