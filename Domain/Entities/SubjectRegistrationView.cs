using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubjectRegistrationView
{
    public long SubjectRegistrationId { get; set; }

    public long ActivityId { get; set; }

    public string? SubjectRegistrationCategoryCode { get; set; }

    public string? SubjectRegistrationCategoryDescription { get; set; }

    public bool AbsconderIndicator { get; set; }

    public bool NonExpiringRegistrationIndicator { get; set; }

    public bool SexualPredatorIndicator { get; set; }

    public bool RegistrationRequiredIndicator { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
