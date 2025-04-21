using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonImageGuidView
{
    public Guid ImageGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? ImageCategoryCode { get; set; }

    public string? ImageFormatCode { get; set; }

    public string? ImageName { get; set; }

    public string? BinaryDescriptionText { get; set; }

    public byte[]? BinaryBase64Object { get; set; }

    public byte[]? BinaryHexObject { get; set; }

    public long? BinarySize { get; set; }

    public string? BinaryLocationUri { get; set; }

    public bool? IsPermanentRecord { get; set; }

    public bool? IsPrivacyAct { get; set; }

    public bool? IsActive { get; set; }

    public int IsSqlstored { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public Guid PersonImageGuid { get; set; }

    public string PersonImageDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? ImageInvolvementCode { get; set; }
}
