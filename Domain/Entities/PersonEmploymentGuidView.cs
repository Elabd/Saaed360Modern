using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonEmploymentGuidView
{
    public Guid PersonEmploymentGuid { get; set; }

    public string PersonEmploymentDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid? EmployerOrganizationGuid { get; set; }

    public Guid? EmployerPersonGuid { get; set; }

    public string? EmployeeIdentification { get; set; }

    public string? EmploymentWorkShiftCode { get; set; }

    public string? EmploymentRankCode { get; set; }

    public string? EmploymentOccupationCode { get; set; }

    public string? EmploymentPositionCode { get; set; }

    public string? EmploymentDepartmentCode { get; set; }

    public string? EmploymentStatusCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
