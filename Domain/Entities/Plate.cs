using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Plate
{
    public double? PlateColorCode { get; set; }

    public string? PlateColorArabicDescription { get; set; }

    public string? PlateColorEnglishDescription { get; set; }

    public double? PlateSourceCode { get; set; }

    public string? PlateSourceArabicDescription { get; set; }

    public string? PlateSourceEnglishDescription { get; set; }

    public double? PlateTypeCode { get; set; }

    public string? PlateTypeArabicDescription { get; set; }

    public string? PlateTypeEnglishDescription { get; set; }

    public double? PlateCategoryCode { get; set; }

    public string? PlateCategoryArabicDescription { get; set; }

    public string? PlateCategoryEnglishDescription { get; set; }

    public string? F13 { get; set; }
}

