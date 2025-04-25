using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Image
{
    public long ImageId { get; set; }

    public Guid ImageGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? ImageCategoryId { get; set; }

    public int? ImageFormatId { get; set; }

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

    public int? RowStatusId { get; set; }

    public virtual ICollection<ActivityImage> ActivityImages { get; set; } = new List<ActivityImage>();

    public virtual ImageCategoryDim? ImageCategory { get; set; }

    public virtual ImageFormatDim? ImageFormat { get; set; }

    public virtual ICollection<ItemImage> ItemImages { get; set; } = new List<ItemImage>();

    public virtual ICollection<LocationImage> LocationImages { get; set; } = new List<LocationImage>();

    public virtual ICollection<MobileRequestImage> MobileRequestImages { get; set; } = new List<MobileRequestImage>();

    public virtual ICollection<OrganizationImage> OrganizationImages { get; set; } = new List<OrganizationImage>();

    public virtual ICollection<PersonImage> PersonImages { get; set; } = new List<PersonImage>();

    public virtual ICollection<PersonPhysicalFeature> PersonPhysicalFeatures { get; set; } = new List<PersonPhysicalFeature>();

    public virtual ICollection<ReportImage> ReportImages { get; set; } = new List<ReportImage>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SaaedIprocessedImage> SaaedIprocessedImages { get; set; } = new List<SaaedIprocessedImage>();

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<SubjectOrganization> SubjectOrganizationCriminalTraitGraffitiImages { get; set; } = new List<SubjectOrganization>();

    public virtual ICollection<SubjectOrganization> SubjectOrganizationCriminalTraitTattooImages { get; set; } = new List<SubjectOrganization>();
}
