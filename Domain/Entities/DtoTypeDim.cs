using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DtoTypeDim
{
    public long DtoTypeId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<OfflineDto> OfflineDtos { get; set; } = new List<OfflineDto>();
}
