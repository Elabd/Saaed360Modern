using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubjectRegistrationGuidView
{
    public Guid SubjectRegistrationGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? SubjectRegistrationCategoryCode { get; set; }

    public bool AbsconderIndicator { get; set; }

    public bool NonExpiringRegistrationIndicator { get; set; }

    public bool SexualPredatorIndicator { get; set; }

    public bool RegistrationRequiredIndicator { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
