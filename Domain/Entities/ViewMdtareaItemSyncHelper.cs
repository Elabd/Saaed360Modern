using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewMdtareaItemSyncHelper
{
    public long AreaItemId { get; set; }

    public long? AreaId { get; set; }

    public long? ItemId { get; set; }

    public bool? IsAttended { get; set; }
}
