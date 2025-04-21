using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ConfWfLevel
{
    public long LevelId { get; set; }

    public string? LevelName { get; set; }

    public string? Description { get; set; }

    public double DelayTimeSpan { get; set; }

    public string? DisplayedMessage { get; set; }

    public long TransId { get; set; }

    public bool UseWhile { get; set; }

    public double? RepeatEvery { get; set; }

    public long? AssociatedActionId { get; set; }

    public virtual ConfWfAction? AssociatedAction { get; set; }

    public virtual ConfWfTransaction Trans { get; set; } = null!;
}
