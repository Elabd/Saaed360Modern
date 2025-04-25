using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Violation
{
    public long Id { get; set; }

    public string? ViolationNumber { get; set; }

    public long? ViolationIncidentId { get; set; }

    public string? Descrption { get; set; }

    public DateTime? ViolationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ViolationTypeDimId { get; set; }

    public long? CityId { get; set; }

    public long? AreaId { get; set; }

    public double? Latitude { get; set; }

    public double? Longtitude { get; set; }

    public string? Address { get; set; }

    public bool? IsCarryPolicePermit { get; set; }

    public string? PermitNo { get; set; }

    public bool? IsPayloadMatching { get; set; }

    public string? PermitNotes { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public long? CurrentStepId { get; set; }

    public long? ViolationVehicleDataId { get; set; }

    public string? RejectionReason { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public virtual ReportAreaDim? Area { get; set; }

    public virtual CityDim? City { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ViolationStepDim? CurrentStep { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ViolationAttachement> ViolationAttachements { get; set; } = new List<ViolationAttachement>();

    public virtual Activity? ViolationIncident { get; set; }

    public virtual ViolationTypeDim? ViolationTypeDim { get; set; }

    public virtual ViolationVehicleDatum? ViolationVehicleData { get; set; }

    public virtual ICollection<ViolationsStep> ViolationsSteps { get; set; } = new List<ViolationsStep>();
}
