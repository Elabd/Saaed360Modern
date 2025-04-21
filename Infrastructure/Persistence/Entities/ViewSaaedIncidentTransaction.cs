using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewSaaedIncidentTransaction
{
    public long TransationId { get; set; }

    public long IncidentId { get; set; }

    public long? PatrolId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public long? SupportId { get; set; }

    public int StatusId { get; set; }

    public string? StatusCode { get; set; }

    public string? StatusDescription { get; set; }

    public int TransactionTypeId { get; set; }

    public string? TransactionTypeCode { get; set; }

    public string? CreatedBy { get; set; }

    public string? SupportDescription { get; set; }

    public string? ItemCode { get; set; }

    public bool? IsAutoDispatch { get; set; }
}
