using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairQuoteItemTypeDim
{
    public int Id { get; set; }

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<RepairQuoteItem> RepairQuoteItems { get; set; } = new List<RepairQuoteItem>();
}
