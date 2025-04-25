using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonEmployment
{
    public long PersonEmploymentId { get; set; }

    public Guid PersonEmploymentGuid { get; set; }

    public string PersonEmploymentDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public long? EmployerOrganizationId { get; set; }

    public Guid? EmployerOrganizationGuid { get; set; }

    public long? EmployerPersonId { get; set; }

    public Guid? EmployerPersonGuid { get; set; }

    public string? EmployeeIdentification { get; set; }

    public int? EmploymentWorkShiftId { get; set; }

    public int? EmploymentRankId { get; set; }

    public int? EmploymentOccupationId { get; set; }

    public int? EmploymentPositionId { get; set; }

    public int? EmploymentDepartmentId { get; set; }

    public int? EmploymentStatusId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Organization? EmployerOrganization { get; set; }

    public virtual Person? EmployerPerson { get; set; }

    public virtual EmploymentDepartmentDim? EmploymentDepartment { get; set; }

    public virtual EmploymentOccupationDim? EmploymentOccupation { get; set; }

    public virtual EmploymentPositionDim? EmploymentPosition { get; set; }

    public virtual EmploymentRankDim? EmploymentRank { get; set; }

    public virtual EmploymentStatusDim? EmploymentStatus { get; set; }

    public virtual EmploymentWorkShiftDim? EmploymentWorkShift { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
