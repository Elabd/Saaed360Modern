using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class WorkerProcessLog
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? MessageTemplate { get; set; }

    public string? Level { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Exception { get; set; }

    public string? Properties { get; set; }

    public string? ApplicationName { get; set; }

    public string? ClassName { get; set; }

    public string? MethodName { get; set; }
}
