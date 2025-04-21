using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Wittness
{
    public int WittnessId { get; set; }

    public string? TrafficCode { get; set; }

    public int? NationalityId { get; set; }

    public string? MobileNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? WittnessTestimony { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? WittnessName { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual NationalityDim? Nationality { get; set; }

    public virtual ICollection<ReportWittness> ReportWittnesses { get; set; } = new List<ReportWittness>();
}
