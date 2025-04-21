using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubjectRegistration
{
    public long SubjectRegistrationId { get; set; }

    public Guid SubjectRegistrationGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int SubjectRegistrationCategoryId { get; set; }

    public bool AbsconderIndicator { get; set; }

    public bool NonExpiringRegistrationIndicator { get; set; }

    public bool SexualPredatorIndicator { get; set; }

    public bool RegistrationRequiredIndicator { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual SubjectRegistrationCategoryDim SubjectRegistrationCategory { get; set; } = null!;
}
