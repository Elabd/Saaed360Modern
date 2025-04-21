using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImpoundApitoken
{
    public long Id { get; set; }

    public string Token { get; set; } = null!;

    public DateTime ExpirationDate { get; set; }
}
