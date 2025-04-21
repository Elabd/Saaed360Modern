using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Document
{
    public long DocumentId { get; set; }

    public Guid DocumentGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? DocumentCategoryId { get; set; }

    public int? DocumentFormatId { get; set; }

    public int? DocumentStatusId { get; set; }

    public string? Title { get; set; }

    public string? FileName { get; set; }

    public string? FileExtension { get; set; }

    public DateTime? FileDateTime { get; set; }

    public string? FileControlNumber { get; set; }

    public string? Description { get; set; }

    public string? DocumentUri { get; set; }

    public byte[]? FileBody { get; set; }

    public string? FileBodyXml { get; set; }

    public bool? PermanentRecordIndicator { get; set; }

    public bool? PrivacyActIndicator { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ActivityDocument> ActivityDocuments { get; set; } = new List<ActivityDocument>();

    public virtual DocumentCategoryDim? DocumentCategory { get; set; }

    public virtual DocumentFormatDim? DocumentFormat { get; set; }

    public virtual DocumentStatusDim? DocumentStatus { get; set; }

    public virtual ICollection<ItemDocument> ItemDocuments { get; set; } = new List<ItemDocument>();

    public virtual ICollection<LocationDocument> LocationDocuments { get; set; } = new List<LocationDocument>();

    public virtual ICollection<OrganizationDocument> OrganizationDocuments { get; set; } = new List<OrganizationDocument>();

    public virtual ICollection<PersonDocument> PersonDocuments { get; set; } = new List<PersonDocument>();

    public virtual Questionnaire? Questionnaire { get; set; }

    public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; } = new List<QuestionnaireQuestion>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
