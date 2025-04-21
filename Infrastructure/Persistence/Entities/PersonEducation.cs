using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonEducation
{
    public long PersonEducationId { get; set; }

    public Guid PersonEducationGuid { get; set; }

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public string? PersonEducationDescription { get; set; }

    public string? StudentIdentification { get; set; }

    public int EducationCategoryId { get; set; }

    public long EducationOrganizationId { get; set; }

    public Guid EducationOrganizationGuid { get; set; }

    public int EducationStatusId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int EducationDegreeId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual EducationCategoryDim EducationCategory { get; set; } = null!;

    public virtual EducationDegreeDim EducationDegree { get; set; } = null!;

    public virtual Organization EducationOrganization { get; set; } = null!;

    public virtual ICollection<EducationSchedule> EducationSchedules { get; set; } = new List<EducationSchedule>();

    public virtual EducationStatusDim EducationStatus { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
