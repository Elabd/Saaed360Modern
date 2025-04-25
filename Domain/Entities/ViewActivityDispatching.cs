using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewActivityDispatching
{
    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int ActivityCategoryId { get; set; }

    public int ActivityReasonId { get; set; }

    public int StatusId { get; set; }

    public string? ActivityName { get; set; }

    public string? ActivityDescription { get; set; }

    public DateTime? ActivityStartDate { get; set; }

    public DateTime? ActivityEndDate { get; set; }

    public DateTime? ActivityDueDate { get; set; }

    public DateTime? ActivityExpirationDate { get; set; }

    public bool? IsCompleted { get; set; }

    public DateTime? ActivityDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public Guid? WorkFlowGuid { get; set; }

    public bool? IsAutoDispatch { get; set; }
}
