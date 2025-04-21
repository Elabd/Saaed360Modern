using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportField
{
    public long FieldId { get; set; }

    public string? FieldName { get; set; }

    public int? FieldTypeId { get; set; }

    public int? ReportTypeId { get; set; }

    public long? GroupId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? CultureDescriptionXml { get; set; }

    public string? Dtoname { get; set; }

    public int? Order { get; set; }

    public string? TableName { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ReportFieldTypeDim? FieldType { get; set; }

    public virtual ReportGroup? Group { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ReportModification> ReportModifications { get; set; } = new List<ReportModification>();

    public virtual ReportTypeDim? ReportType { get; set; }
}
