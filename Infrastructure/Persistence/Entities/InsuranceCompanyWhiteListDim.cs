using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class InsuranceCompanyWhiteListDim
{
    public int InsuranceCompanyId { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }
}
