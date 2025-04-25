using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MissingPerson
{
    public long PersonId { get; set; }

    public int? MissingPersonCategoryId { get; set; }

    public int? MissingPersonCircumstanceId { get; set; }

    public int? MissingPersonStatusId { get; set; }

    public long? DeclarationPersonId { get; set; }

    public Guid DeclarationPersonGuid { get; set; }

    public long? FoundLocationId { get; set; }

    public Guid FoundLocationGuid { get; set; }

    public long? LastSeenLocationId { get; set; }

    public Guid LastSeenLocationGuid { get; set; }

    public DateTime? DeclarationDate { get; set; }

    public DateTime? LastSeenDate { get; set; }

    public DateTime? FoundDate { get; set; }

    public bool? InterestIndicator { get; set; }

    public bool? FoundIndicator { get; set; }

    public virtual Person? DeclarationPerson { get; set; }

    public virtual Location? FoundLocation { get; set; }

    public virtual Location? LastSeenLocation { get; set; }

    public virtual MissingPersonCategoryDim? MissingPersonCategory { get; set; }

    public virtual MissingPersonCircumstanceDim? MissingPersonCircumstance { get; set; }

    public virtual MissingPersonStatusDim? MissingPersonStatus { get; set; }

    public virtual Person Person { get; set; } = null!;
}
