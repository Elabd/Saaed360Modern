using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class InsuranceCompanyWhiteListDim
{
    public int InsuranceCompanyId { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }
}
