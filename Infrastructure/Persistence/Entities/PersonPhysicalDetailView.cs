using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonPhysicalDetailView
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

    public string? PersonSexCode { get; set; }

    public string? PersonSexDescription { get; set; }

    public string? PersonRaceCode { get; set; }

    public string? PersonRaceDescription { get; set; }

    public string? PersonEyeColorCode { get; set; }

    public string? PersonEyeColorDescription { get; set; }

    public string? PersonBuildCode { get; set; }

    public string? PersonBuildDescription { get; set; }

    public string? PersonHairStyleCode { get; set; }

    public string? PersonHairStyleDescription { get; set; }

    public string? PersonFacialHairCode { get; set; }

    public string? PersonFacialHairDescription { get; set; }

    public string? PersonComplexionCode { get; set; }

    public string? PersonComplexionDescription { get; set; }

    public string? PersonHairAppearanceCode { get; set; }

    public string? PersonHairAppearanceDescription { get; set; }

    public string? PersonJewelryCode { get; set; }

    public string? PersonJewelryDescription { get; set; }

    public string? PersonGeneralAppearanceCode { get; set; }

    public string? PersonGeneralAppearanceDescription { get; set; }

    public string? PersonDisguiseCode { get; set; }

    public string? PersonDisguiseDescription { get; set; }

    public string? PersonHandednessCode { get; set; }

    public string? PersonHandednessDescription { get; set; }

    public string? PersonSpeechCode { get; set; }

    public string? PersonSpeechDescription { get; set; }

    public string? PersonBodyPartStatusCode { get; set; }

    public string? PersonBodyPartStatusDescription { get; set; }

    public string? PersonEyeWearCode { get; set; }

    public string? PersonEyeWearDescription { get; set; }

    public string? PersonCircumcisionCode { get; set; }

    public string? PersonCircumcisionDescription { get; set; }

    public bool? PersonFootPrintAvailableIndicator { get; set; }
}
