using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewMobileRequestList
{
    public long RequestNumber { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Description { get; set; }

    public DateTime CreateDate { get; set; }

    public int? MobileRequestStatusId { get; set; }

    public string? Code { get; set; }

    public int? IncidentTypeId { get; set; }

    public string? IncidentTypeAr { get; set; }

    public string? IncidentTypeEn { get; set; }

    public int? RequestTypeCode { get; set; }

    public string? StatusDescriptionAr { get; set; }

    public string? StatusDescriptionEn { get; set; }

    public string? RecievedBy { get; set; }

    public long AreaId { get; set; }

    public string? Area { get; set; }

    public long? PersonId { get; set; }
}
