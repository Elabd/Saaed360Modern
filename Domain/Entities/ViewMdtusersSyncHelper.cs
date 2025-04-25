using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewMdtusersSyncHelper
{
    public Guid ApplicationId { get; set; }

    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string LoweredUserName { get; set; } = null!;

    public string? MobileAlias { get; set; }

    public bool IsAnonymous { get; set; }

    public DateTime LastActivityDate { get; set; }

    public long Id { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public bool? IsFromActiveDirectory { get; set; }
}
