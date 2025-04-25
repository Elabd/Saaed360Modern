using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SmstoWhatsDetail
{
    public long SmstoWhatsDetailsId { get; set; }

    public long SmstoWhatsupId { get; set; }

    public string SmstemplateParameterKey { get; set; } = null!;

    public string WhatsTemplateParameterKey { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public virtual SmstoWhatsMapping SmstoWhatsup { get; set; } = null!;
}
