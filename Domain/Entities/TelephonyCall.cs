using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TelephonyCall
{
    public long Id { get; set; }

    public Guid? Wfid { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public string? CallerNumber { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? CallerName { get; set; }

    public long? ReceivedBy { get; set; }

    public bool? IsWanted { get; set; }

    public string? SmsContent { get; set; }

    public DateOnly? DateofBirth { get; set; }

    public string? Occupation { get; set; }

    public string? MaritialStatus { get; set; }

    public string? Address { get; set; }

    public byte[]? Images { get; set; }

    public string? NationalityId { get; set; }

    public virtual ICollection<TelephonyCallLog> TelephonyCallLogs { get; set; } = new List<TelephonyCallLog>();
}
