using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PasswordDictionary
{
    public long Id { get; set; }

    public int TypeId { get; set; }

    public string Password { get; set; } = null!;

    public string? FileName { get; set; }

    public DateTime? FileUpdateDate { get; set; }

    public DateTime ImportDate { get; set; }

    public virtual PasswordEntryTypeDim Type { get; set; } = null!;
}
