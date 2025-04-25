using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GetDeviceListByRole
{
    public Guid? RoleId { get; set; }

    public long? OrganizationId { get; set; }

    public long ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public Guid ItemGuid { get; set; }
}
