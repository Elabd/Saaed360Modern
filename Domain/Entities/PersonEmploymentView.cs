using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonEmploymentView
{
    public long PersonEmploymentId { get; set; }

    public string PersonEmploymentDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long? EmployerOrganizationId { get; set; }

    public long? EmployerPersonId { get; set; }

    public string? EmployeeIdentification { get; set; }

    public string? EmploymentWorkShiftCode { get; set; }

    public string? EmploymentWorkShiftDescription { get; set; }

    public string? EmploymentRankCode { get; set; }

    public string? EmploymentRankDescription { get; set; }

    public string? EmploymentOccupationCode { get; set; }

    public string? EmploymentOccupationDescription { get; set; }

    public string? EmploymentPositionCode { get; set; }

    public string? EmploymentPositionDescription { get; set; }

    public string? EmploymentDepartmentCode { get; set; }

    public string? EmploymentDepartmentDescription { get; set; }

    public string? EmploymentStatusCode { get; set; }

    public string? EmploymentStatusDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
