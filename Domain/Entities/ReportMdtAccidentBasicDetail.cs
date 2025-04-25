using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportMdtAccidentBasicDetail
{
    public int ReportMdtAccidentBasicDetailsId { get; set; }

    public int? MdtaccidentBasicDetailsId { get; set; }

    public int? ReportId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual MdtaccidentBasicDetail? MdtaccidentBasicDetails { get; set; }

    public virtual Report? Report { get; set; }
}
