using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemImageView
{
    public long ImageId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? ImageCategoryCode { get; set; }

    public string? ImageCategoryDescription { get; set; }

    public string? ImageFormatCode { get; set; }

    public string? ImageFormatDescription { get; set; }

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

    public string? RowStatusDescription { get; set; }

    public long ItemImageId { get; set; }

    public string ItemImageDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public string? ImageInvolvementDescription { get; set; }
}
