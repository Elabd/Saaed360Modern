using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonEducationGuidView
{
    public Guid PersonEducationGuid { get; set; }

    public Guid PersonGuid { get; set; }

    public string? PersonEducationDescription { get; set; }

    public string? StudentIdentification { get; set; }

    public string? EducationCategoryCode { get; set; }

    public Guid EducationOrganizationGuid { get; set; }

    public string? EducationStatusCode { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? EducationDegreeCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
