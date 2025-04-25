using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MdtViewReportWittness
{
    public int ReportId { get; set; }

    public string? WittnessName { get; set; }

    public int WittnessId { get; set; }

    public string? TrafficCode { get; set; }

    public int? NationalityId { get; set; }

    public string? MobileNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? WittnessTestimony { get; set; }
}
