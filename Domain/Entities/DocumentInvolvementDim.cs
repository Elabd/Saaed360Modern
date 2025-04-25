using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DocumentInvolvementDim
{
    public int DocumentInvolvementId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ActivityDocument> ActivityDocuments { get; set; } = new List<ActivityDocument>();

    public virtual ICollection<ItemDocument> ItemDocuments { get; set; } = new List<ItemDocument>();

    public virtual ICollection<LocationDocument> LocationDocuments { get; set; } = new List<LocationDocument>();

    public virtual ICollection<OrganizationDocument> OrganizationDocuments { get; set; } = new List<OrganizationDocument>();

    public virtual ICollection<PersonDocument> PersonDocuments { get; set; } = new List<PersonDocument>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
