using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Offense
{
    public long OffenseId { get; set; }

    public Guid OffenseGuid { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? OffenseCodeId { get; set; }

    public int? EntryPassagePointId { get; set; }

    public int? ExitPassagePointId { get; set; }

    public bool? IdentityTheftIndicator { get; set; }

    public bool? HomeInvasionIndicator { get; set; }

    public bool? GangInvolvementIndicator { get; set; }

    public bool? TerrorismIndicator { get; set; }

    public bool? AttemptedIndicator { get; set; }

    public bool? CargoTheftIndicator { get; set; }

    public bool? DomesticViolenceIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual PassagePointTypeDim? EntryPassagePoint { get; set; }

    public virtual PassagePointTypeDim? ExitPassagePoint { get; set; }

    public virtual ICollection<OffenseChargeAssociation> OffenseChargeAssociations { get; set; } = new List<OffenseChargeAssociation>();

    public virtual ICollection<OffenseCitationAssociation> OffenseCitationAssociations { get; set; } = new List<OffenseCitationAssociation>();

    public virtual OffenseCodeDim? OffenseCode { get; set; }

    public virtual ICollection<OffenseIncidentAssociation> OffenseIncidentAssociations { get; set; } = new List<OffenseIncidentAssociation>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
