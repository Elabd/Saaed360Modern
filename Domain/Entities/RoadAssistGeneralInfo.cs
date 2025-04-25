using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistGeneralInfo
{
    public Guid Id { get; set; }

    public string TitleEn { get; set; } = null!;

    public string TitleAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public string DescriptionAr { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string ServiceFeesTextEn { get; set; } = null!;

    public string ServiceFeesTextAr { get; set; } = null!;

    public string RequiredDocumentsTextEn { get; set; } = null!;

    public string RequiredDocumentsTextAr { get; set; } = null!;

    public string ProcessTimeTextEn { get; set; } = null!;

    public string ProcessTimeTextAr { get; set; } = null!;
}
