using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonMilitarySummary
{
    public long PersonMilitarySummaryId { get; set; }

    public Guid PersonMilitarySummaryGuid { get; set; }

    public string PersonMilitarySummaryDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? MilitaryBranchId { get; set; }

    public int? MilitaryStatusId { get; set; }

    public int? MilitaryServiceTypeId { get; set; }

    public int? MilitaryDischargeTypeId { get; set; }

    public DateTime? ServiceStart { get; set; }

    public DateTime? ServiceEnd { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual MilitaryBranchDim? MilitaryBranch { get; set; }

    public virtual MilitaryDischargeTypeDim? MilitaryDischargeType { get; set; }

    public virtual MilitaryServiceTypeDim? MilitaryServiceType { get; set; }

    public virtual MilitaryStatusDim? MilitaryStatus { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
