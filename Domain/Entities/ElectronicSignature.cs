using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ElectronicSignature
{
    public long ElectronicSignatureId { get; set; }

    public string? Notes { get; set; }

    public byte[]? SigningImage { get; set; }

    public byte[]? SigningPoints { get; set; }

    public bool? IsClientSignature { get; set; }

    public int? ReportId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? CreatedBy { get; set; }

    public long? LastModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Report? Report { get; set; }
}
