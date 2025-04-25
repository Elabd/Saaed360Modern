using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WebApiRequestsLog
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? Level { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? ApplicationName { get; set; }

    public string? RequestId { get; set; }

    public string? HttpStatusCode { get; set; }

    public double? ElapsedMilliseconds { get; set; }

    public string? DetailedMessage { get; set; }

    public string? RequestPath { get; set; }

    public string? ActionName { get; set; }

    public string? RequestHeaders { get; set; }

    public string? RequestParameters { get; set; }

    public string? RequestBody { get; set; }

    public string? MachineName { get; set; }

    public string? Ipaddress { get; set; }

    public string? UserAgent { get; set; }
}
