using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonVitalStatistic
{
    public long PersonId { get; set; }

    public int PersonReligionId { get; set; }

    public int? EthnicityId { get; set; }

    public int? PersonHairColorId { get; set; }

    public int? PersonSkinToneId { get; set; }

    public int? PersonMaritalStatusId { get; set; }

    public int? PersonSexualOrientationId { get; set; }

    public DateTime? PersonBirthDate { get; set; }

    public DateTime? PersonDeathDate { get; set; }

    public string? PersonHeight { get; set; }

    public string? PersonHeightMin { get; set; }

    public string? PersonHeightmax { get; set; }

    public string? PersonWeight { get; set; }

    public string? PersonWeightMin { get; set; }

    public string? PersonWeightMax { get; set; }

    public int? PersonBodyXrayId { get; set; }

    public int? PersonDeathCauseId { get; set; }

    public int? PersonBloodTypeId { get; set; }

    public string? PersonVitalStatisticDescription { get; set; }

    public long SourceId { get; set; }

    public int? RowStatusId { get; set; }

    public virtual EthnicityDim? Ethnicity { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonBodyXrayDim? PersonBodyXray { get; set; }

    public virtual PersonHairColorDim? PersonHairColor { get; set; }

    public virtual PersonMaritalStatusDim? PersonMaritalStatus { get; set; }

    public virtual PersonReligionDim PersonReligion { get; set; } = null!;

    public virtual PersonSexualOrientationDim? PersonSexualOrientation { get; set; }

    public virtual PersonSkinToneDim? PersonSkinTone { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
