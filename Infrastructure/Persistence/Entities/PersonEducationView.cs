using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonEducationView
{
    public long PersonEducationId { get; set; }

    public long PersonId { get; set; }

    public string? PersonEducationDescription { get; set; }

    public string? StudentIdentification { get; set; }

    public string? EducationCategoryCode { get; set; }

    public string? EducationCategoryDescription { get; set; }

    public long EducationOrganizationId { get; set; }

    public string? EducationStatusCode { get; set; }

    public string? EducationStatusDescription { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? EducationDegreeCode { get; set; }

    public string? EducationDegreeDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
