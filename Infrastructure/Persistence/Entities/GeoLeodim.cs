using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoLeodim
{
    public int GeoLeoid { get; set; }

    public string Code { get; set; } = null!;

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? Division { get; set; }

    public string? DivisionCode { get; set; }

    public string? District { get; set; }

    public string? DistrictCode { get; set; }

    public string? Sector { get; set; }

    public string? SectorCode { get; set; }

    public string? Beat { get; set; }

    public string? BeatCode { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }
}
