using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VObjectionFinancialReport
{
    public long ObjectionId { get; set; }

    public DateTime ObjectionDate { get; set; }

    public string MobileNumber { get; set; } = null!;

    public string? RequesterName { get; set; }

    public int? ReportId { get; set; }

    public int? RequestTypeId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? TotalAmount { get; set; }

    public int? PaymentStatusId { get; set; }

    public string? ArabicDescription { get; set; }

    public string? PaymentStatusName { get; set; }

    public string? EmirateName { get; set; }

    public long? EmiratesId { get; set; }
}
