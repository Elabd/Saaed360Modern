using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class JudicialOfficial
{
    public long PersonId { get; set; }

    public int JudicialOfficialBarStatusId { get; set; }

    public int JudicialOfficialCategoryId { get; set; }

    public int JudicialOfficialPanelId { get; set; }

    public string? JudicialOfficialBarIdentification { get; set; }

    public string? IdentificationJurisdiction { get; set; }

    public string? JudicialOfficialRegIdentification { get; set; }

    public virtual JudicialOfficialBarStatusDim JudicialOfficialBarStatus { get; set; } = null!;

    public virtual JudicialOfficialCategoryDim JudicialOfficialCategory { get; set; } = null!;

    public virtual JudicialOfficialPanelDim JudicialOfficialPanel { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
