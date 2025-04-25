using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsConditionDim
{
    public int Id { get; set; }

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string NameUrdu { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<EsAttachment> EsAttachments { get; set; } = new List<EsAttachment>();

    public virtual ICollection<EsInput> EsInputConditions { get; set; } = new List<EsInput>();

    public virtual ICollection<EsInput> EsInputSelectorConditions { get; set; } = new List<EsInput>();
}
