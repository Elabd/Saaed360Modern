using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonPhysicalDetail
{
    public long PersonId { get; set; }

    public int? PersonSexId { get; set; }

    public int? PersonRaceId { get; set; }

    public int? PersonEyeColorId { get; set; }

    public int? PersonBuildId { get; set; }

    public int? PersonHairStyleId { get; set; }

    public int? PersonFacialHairId { get; set; }

    public int? PersonComplexionId { get; set; }

    public int? PersonHairAppearanceId { get; set; }

    public int? PersonJewelryId { get; set; }

    public int? PersonGeneralAppearanceId { get; set; }

    public int? PersonDisguiseId { get; set; }

    public int PersonHandednessId { get; set; }

    public int? PersonSpeechId { get; set; }

    public int? PersonBodyPartStatusId { get; set; }

    public int? PersonEyeWearId { get; set; }

    public int? PersonCircumcisionId { get; set; }

    public bool? PersonFootPrintAvailableIndicator { get; set; }

    public string? Description { get; set; }

    public long? SourceId { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonBodyPartStatusDim? PersonBodyPartStatus { get; set; }

    public virtual PersonBuildDim? PersonBuild { get; set; }

    public virtual PersonCircumcisionDim? PersonCircumcision { get; set; }

    public virtual PersonComplexionDim? PersonComplexion { get; set; }

    public virtual PersonDisguiseDim? PersonDisguise { get; set; }

    public virtual PersonEyeColorDim? PersonEyeColor { get; set; }

    public virtual PersonEyeWearDim? PersonEyeWear { get; set; }

    public virtual PersonFacialHairDim? PersonFacialHair { get; set; }

    public virtual PersonGeneralAppearanceDim? PersonGeneralAppearance { get; set; }

    public virtual PersonHairAppearanceDim? PersonHairAppearance { get; set; }

    public virtual PersonHairStyleDim? PersonHairStyle { get; set; }

    public virtual PersonHandednessDim PersonHandedness { get; set; } = null!;

    public virtual PersonJewelryDim? PersonJewelry { get; set; }

    public virtual PersonRaceDim? PersonRace { get; set; }

    public virtual PersonSexDim? PersonSex { get; set; }

    public virtual PersonSpeechDim? PersonSpeech { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source? Source { get; set; }
}
