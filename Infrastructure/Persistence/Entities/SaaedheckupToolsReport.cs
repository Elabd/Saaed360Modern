using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedheckupToolsReport
{
    public long LoginId { get; set; }

    public long PersonId { get; set; }

    public string? PersonName { get; set; }

    public long? PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public string? Code { get; set; }

    public long CheckListActivityId { get; set; }

    public string SourceOfCheckup { get; set; } = null!;

    public string SourceOfCheckupText { get; set; } = null!;

    public string? Comment { get; set; }

    public DateTime? CheckListDate { get; set; }

    public string? ControlCenter { get; set; }

    public long? ControlCenterId { get; set; }

    public string? Device { get; set; }
}
