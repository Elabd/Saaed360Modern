using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GeoCountryDim
{
    public int GeoCountryId { get; set; }

    public string Code { get; set; } = null!;

    public string? CountryName { get; set; }

    public string? CountryLongName { get; set; }

    public string? CountryFips104 { get; set; }

    public string? CountryCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonCitizenship> PersonCitizenships { get; set; } = new List<PersonCitizenship>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<Vessel> Vessels { get; set; } = new List<Vessel>();
}
