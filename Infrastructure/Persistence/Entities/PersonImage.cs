using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonImage
{
    public long PersonImageId { get; set; }

    public Guid PersonImageGuid { get; set; }

    public string PersonImageDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long ImageId { get; set; }

    public Guid ImageGuid { get; set; }

    public int ImageInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Image Image { get; set; } = null!;

    public virtual ImageInvolvementDim ImageInvolvement { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<PersonDriverLicense> PersonDriverLicenses { get; set; } = new List<PersonDriverLicense>();

    public virtual ICollection<PersonFingerprintSet> PersonFingerprintSets { get; set; } = new List<PersonFingerprintSet>();

    public virtual ICollection<PersonOtherIdentification> PersonOtherIdentifications { get; set; } = new List<PersonOtherIdentification>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual ICollection<Subject> SubjectCriminalTraitGraffitiImages { get; set; } = new List<Subject>();

    public virtual ICollection<Subject> SubjectCriminalTraitTattooImages { get; set; } = new List<Subject>();
}
