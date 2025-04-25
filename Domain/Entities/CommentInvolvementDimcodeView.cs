using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CommentInvolvementDimcodeView
{
    public string? CommentInvolvementDescription { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
