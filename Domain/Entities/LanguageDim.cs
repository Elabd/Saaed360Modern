using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LanguageDim
{
    public int LanguageId { get; set; }

    public string? Description { get; set; }

    public string? Isocode6392 { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();

    public virtual ICollection<PersonLanguage> PersonLanguages { get; set; } = new List<PersonLanguage>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
