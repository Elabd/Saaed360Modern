using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VSmstoWhatsMapping
{
    public long SmstoWhatsupId { get; set; }

    public int SmstemplateId { get; set; }

    public int WhatsUpTemplateId { get; set; }

    public string SmsarabicLangToWhatsLang { get; set; } = null!;

    public string SmsenglishLangToWhatsLang { get; set; } = null!;

    public bool IsWhatsForced { get; set; }

    public bool IsSmsretry { get; set; }

    public int SmsretryPeriodSecs { get; set; }

    public string MessageTemplateCode { get; set; } = null!;
}
