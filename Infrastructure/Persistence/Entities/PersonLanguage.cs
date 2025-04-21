using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonLanguage
{
    public long PersonLanguageId { get; set; }

    public Guid PersonLanguageGuid { get; set; }

    public string PersonLanguageDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int LanguageId { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsSpoken { get; set; }

    public bool? IsRead { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual LanguageDim Language { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
