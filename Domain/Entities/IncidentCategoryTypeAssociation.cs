using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentCategoryTypeAssociation
{
    public long IncidentCategoryTypeAssociationId { get; set; }

    public int ServiceCallCategoryId { get; set; }

    public int ServiceCallIncidentTypeId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ServiceCallCategoryDim ServiceCallCategory { get; set; } = null!;

    public virtual ServiceCallIncidentTypeDim ServiceCallIncidentType { get; set; } = null!;
}
