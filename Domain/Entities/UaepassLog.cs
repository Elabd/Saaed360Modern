using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UaepassLog
{
    public long Id { get; set; }

    public string? AssuranceLevel { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Uuid { get; set; }

    public string? Spuuid { get; set; }

    public string? EmirateId { get; set; }

    public string? NationalityEn { get; set; }

    public string? NationalityAr { get; set; }

    public string? Gender { get; set; }

    public string? TypeId { get; set; }

    public string? FullnameEn { get; set; }

    public string? FullnameAr { get; set; }

    public bool? IsFirstRegisterSaaed { get; set; }

    public long? MobileUserId { get; set; }

    public string? TitleEn { get; set; }

    public string? TitleAr { get; set; }

    public DateTime? CreationDateTime { get; set; }
}
