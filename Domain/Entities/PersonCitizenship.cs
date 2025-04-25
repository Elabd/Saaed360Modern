using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonCitizenship
{
    public long PersonCitizenshipId { get; set; }

    public Guid PersonCitizenshipGuid { get; set; }

    public string PersonCitizenshipDescription { get; set; } = null!;

    public long? PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long? SourceId { get; set; }

    public int? GeoCountryid { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual GeoCountryDim? GeoCountry { get; set; }

    public virtual Person? Person { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source? Source { get; set; }
}
