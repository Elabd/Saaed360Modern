using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonVitalStatisticView
{
    public long PersonId { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? PersonStatusCode { get; set; }

    public string? PersonStatusDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Moniker { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public int? PersonCategoryId { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public string? PersonReligionCode { get; set; }

    public string? PersonReligionDescription { get; set; }

    public string? EthnicityCode { get; set; }

    public string? EthnicityDescription { get; set; }

    public string? PersonHairColorCode { get; set; }

    public string? PersonHairColorDescription { get; set; }

    public string? PersonSkinToneCode { get; set; }

    public string? PersonSkinToneDescription { get; set; }

    public string? PersonMaritalStatusCode { get; set; }

    public string? PersonMaritalStatusDescription { get; set; }

    public string? PersonSexualOrientationCode { get; set; }

    public string? PersonSexualOrientationDescription { get; set; }

    public DateTime? PersonBirthDate { get; set; }

    public DateTime? PersonDeathDate { get; set; }

    public string? PersonHeight { get; set; }

    public string? PersonHeightMin { get; set; }

    public string? PersonHeightmax { get; set; }

    public string? PersonWeight { get; set; }

    public string? PersonWeightMin { get; set; }

    public string? PersonWeightMax { get; set; }

    public string? PersonBodyXrayCode { get; set; }

    public string? PersonBodyXrayDescription { get; set; }

    public int? PersonDeathCauseId { get; set; }

    public int? PersonBloodTypeId { get; set; }

    public string? PersonVitalStatisticDescription { get; set; }
}
