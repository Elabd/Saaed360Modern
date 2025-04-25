using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VGetRequestsList
{
    public long Id { get; set; }

    public long RequestId { get; set; }

    public string? RequestNumber { get; set; }

    public string? ReportNumber { get; set; }

    public string? Description { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? CreationPerson { get; set; }

    public long? CreatedBy { get; set; }

    public string? ModifiedPerson { get; set; }

    public long? ModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ReportModificationStatusId { get; set; }

    public long? StateId { get; set; }

    public long? ApprovalCycleId { get; set; }

    public int? RequestTypeId { get; set; }

    public int? SourceOfModificationId { get; set; }

    public string? SourceOfModification { get; set; }

    public int? ResponsibilityId { get; set; }

    public bool? IsExternal { get; set; }

    public string Code { get; set; } = null!;

    public int? Rank { get; set; }

    public long? FieldId { get; set; }

    public long ReportModificationId { get; set; }

    public long? ReportModificationLogId { get; set; }

    public long? EmirateId { get; set; }

    public long? CityId { get; set; }

    public bool? IsTransfered { get; set; }
}
