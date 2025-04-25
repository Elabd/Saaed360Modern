using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventIncidentImage
{
    public long Id { get; set; }

    public string? Img { get; set; }

    public long? IncidentId { get; set; }

    public long? IncidentVehicleId { get; set; }

    public long? IncidentPersonId { get; set; }

    public DateTime? CreateTime { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModificationBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? IncidentCommentId { get; set; }

    public double? ImgSize { get; set; }

    public string? ImgType { get; set; }

    public string? BinaryLocationUri { get; set; }

    public string? ImgName { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventIncident? Incident { get; set; }

    public virtual EventIncidentComment? IncidentComment { get; set; }

    public virtual EventIncidentPerson? IncidentPerson { get; set; }

    public virtual EventIncidentVehicle? IncidentVehicle { get; set; }

    public virtual Person? ModificationByNavigation { get; set; }
}
