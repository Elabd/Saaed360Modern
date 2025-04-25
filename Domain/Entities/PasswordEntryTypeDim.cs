using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PasswordEntryTypeDim
{
    public int Id { get; set; }

    public string EntryType { get; set; } = null!;

    public virtual ICollection<PasswordDictionary> PasswordDictionaries { get; set; } = new List<PasswordDictionary>();
}
