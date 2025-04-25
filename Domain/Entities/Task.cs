using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Task
{
    public long TaskId { get; set; }

    public string? TaskName { get; set; }

    public string? Description { get; set; }

    public DateTime? TaskDate { get; set; }

    public long? CreatedBy { get; set; }

    public long? TaskCategoryId { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? RowStatus { get; set; }

    public byte[]? TimeStamp { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<ActivityTask> ActivityTasks { get; set; } = new List<ActivityTask>();

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual TaskCategoryDim? TaskCategory { get; set; }

    public virtual ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
}
