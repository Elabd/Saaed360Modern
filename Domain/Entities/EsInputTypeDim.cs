using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsInputTypeDim
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<EsInput> EsInputs { get; set; } = new List<EsInput>();
}
