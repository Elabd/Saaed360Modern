using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewActivityTransactionStatusOrgDetail
{
    public long TransationId { get; set; }

    public long ActivityId { get; set; }

    public int TransationTypeId { get; set; }

    public long? ItemId { get; set; }

    public long? OrganizationId { get; set; }

    public int StatusId { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreationDateTime { get; set; }

    public string? Temp { get; set; }

    public long? TempId { get; set; }

    public long? Teid { get; set; }

    public bool? IsAutoDispatch { get; set; }

    public string? StatusName { get; set; }

    public string? OrgName { get; set; }

    public int? OrganizationCategoryId { get; set; }
}
