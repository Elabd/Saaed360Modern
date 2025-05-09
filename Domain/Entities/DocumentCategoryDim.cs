using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DocumentCategoryDim
{
    public int DocumentCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<ReportRequestDocument> ReportRequestDocuments { get; set; } = new List<ReportRequestDocument>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
