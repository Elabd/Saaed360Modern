using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewPersonArea
{
    public long PersonId { get; set; }

    public string PersonFullName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public long AreaId { get; set; }

    public string? AreaName { get; set; }

    public long ControlRoomId { get; set; }

    public string? ControlReoomName { get; set; }

    public int? PersonCategoryId { get; set; }

    public Guid UserId { get; set; }
}
