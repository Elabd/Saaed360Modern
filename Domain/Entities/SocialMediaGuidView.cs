using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaGuidView
{
    public Guid SocialMediaGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SocialMediaCategoryCode { get; set; }

    public string? Account { get; set; }

    public string Uri { get; set; } = null!;

    public string? Information { get; set; }

    public string? Title { get; set; }

    public string? RawData { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
