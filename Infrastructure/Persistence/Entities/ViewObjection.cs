using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewObjection
{
    public string? ReportNumber { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public int? ReportId { get; set; }

    public long ObjectionId { get; set; }

    public DateTime ObjectionDate { get; set; }

    public string ObjectionSubject { get; set; } = null!;

    public string ObjectionBody { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public DateTime? IncidentApproximateDateFrom { get; set; }

    public DateTime? IncidentApproximateDateTo { get; set; }

    public int ObjectionLanguage { get; set; }

    public string? AreaDescription { get; set; }

    public long? AreaId { get; set; }

    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public string? Name { get; set; }

    public int? RequestTypeId { get; set; }

    public string? ArabicDescription { get; set; }

    public bool? IsConvertedToCenter { get; set; }

    public long? DepartmentId { get; set; }

    public int? ReasonId { get; set; }

    public string? CenterComment { get; set; }

    public string? NationalId { get; set; }

    public string? NationalityTxt { get; set; }

    public int? NationalityId { get; set; }

    public int? SourceOfRequestId { get; set; }

    public string? OtherSourceOfRequest { get; set; }

    public string? RejectionReason { get; set; }

    public int? ObjectionResultId { get; set; }

    public string? Nationality { get; set; }

    public string ObjectionSource { get; set; } = null!;

    public string? ReporterName { get; set; }

    public string? PersonCode { get; set; }

    public string? ReporterDep { get; set; }

    public long? EmiratesId { get; set; }

    public long? ObjectionEmirateId { get; set; }

    public string? VehicleNumber { get; set; }

    public int? RequestModificationId { get; set; }

    public string? RequestModification { get; set; }

    public string? LicenceNumber { get; set; }

    public int? ExemptionRequestTypeId { get; set; }

    public string? ExemptionRequestType { get; set; }

    public long? CityId { get; set; }

    public string? CityName { get; set; }

    public string? UnknownObjectionArea { get; set; }

    public string? ReturnReason { get; set; }

    public int? SourceOfRequestVehicleId { get; set; }

    public bool IsNew { get; set; }
}
