using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceLogTable
{
    public int LogId { get; set; }

    public string? LogDetails { get; set; }

    /// <summary>
    /// 1- Info message  2- return error message  3- exception message
    /// </summary>
    public int? LogType { get; set; }

    /// <summary>
    /// 1- for Report Upload Service  2- Saaed360 Reporting Service
    /// </summary>
    public int? ServicesName { get; set; }

    public DateTime TimeStamp { get; set; }
}

