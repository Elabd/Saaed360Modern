using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsStep
{
    public int Id { get; set; }

    public int Index { get; set; }

    public int ServiceId { get; set; }

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string NameUrdu { get; set; } = null!;

    public int UserControlId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public bool IsDeleted { get; set; }

    public virtual EsService Service { get; set; } = null!;

    public virtual EsUserControlDim UserControl { get; set; } = null!;
}
