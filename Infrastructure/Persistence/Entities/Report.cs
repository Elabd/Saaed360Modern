using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Report
{
    public int ReportId { get; set; }

    public Guid ReportGuid { get; set; }

    public string? ReportNumber { get; set; }

    public int? ReportTypeId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime ReportDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsUploaded { get; set; }

    public bool? IsTransferedFromPolice { get; set; }

    public DateTime? PoliceTransferDateTime { get; set; }

    public int? ReportSourceTypeId { get; set; }

    public long? ReportSourceId { get; set; }

    public virtual ICollection<ActivityConvertToStationArc> ActivityConvertToStationArcs { get; set; } = new List<ActivityConvertToStationArc>();

    public virtual ICollection<ActivityReport> ActivityReports { get; set; } = new List<ActivityReport>();

    public virtual ICollection<ElectronicSignature> ElectronicSignatures { get; set; } = new List<ElectronicSignature>();

    public virtual ICollection<EscortingReportBasicDetail> EscortingReportBasicDetails { get; set; } = new List<EscortingReportBasicDetail>();

    public virtual ICollection<MobileRequest> MobileRequests { get; set; } = new List<MobileRequest>();

    public virtual ICollection<Objection> Objections { get; set; } = new List<Objection>();

    public virtual ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();

    public virtual ICollection<RecalculationReportChengeLog> RecalculationReportChengeLogs { get; set; } = new List<RecalculationReportChengeLog>();

    public virtual ICollection<RecalculationRequest> RecalculationRequests { get; set; } = new List<RecalculationRequest>();

    public virtual ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();

    public virtual ICollection<ReportActionTaken> ReportActionTakens { get; set; } = new List<ReportActionTaken>();

    public virtual ICollection<ReportAmbulance> ReportAmbulances { get; set; } = new List<ReportAmbulance>();

    public virtual ICollection<ReportChangeStatusLog> ReportChangeStatusLogs { get; set; } = new List<ReportChangeStatusLog>();

    public virtual ICollection<ReportDamagedProperty> ReportDamagedProperties { get; set; } = new List<ReportDamagedProperty>();

    public virtual ICollection<ReportFile> ReportFiles { get; set; } = new List<ReportFile>();

    public virtual ICollection<ReportImage> ReportImages { get; set; } = new List<ReportImage>();

    public virtual ICollection<ReportInquiryLog> ReportInquiryLogs { get; set; } = new List<ReportInquiryLog>();

    public virtual ICollection<ReportMdtAccidentBasicDetail> ReportMdtAccidentBasicDetails { get; set; } = new List<ReportMdtAccidentBasicDetail>();

    public virtual ICollection<ReportModification> ReportModifications { get; set; } = new List<ReportModification>();

    public virtual ICollection<ReportPaymentTransaction> ReportPaymentTransactions { get; set; } = new List<ReportPaymentTransaction>();

    public virtual ICollection<ReportReconstructionPlan> ReportReconstructionPlans { get; set; } = new List<ReportReconstructionPlan>();

    public virtual ICollection<ReportRequest> ReportRequests { get; set; } = new List<ReportRequest>();

    public virtual ReportSourceTypeDim? ReportSourceType { get; set; }

    public virtual ReportStatusDim? ReportStatus { get; set; }

    public virtual ReportTypeDim? ReportType { get; set; }

    public virtual ICollection<ReportVehicleDatum> ReportVehicleData { get; set; } = new List<ReportVehicleDatum>();

    public virtual ICollection<ReportWittness> ReportWittnesses { get; set; } = new List<ReportWittness>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspProcedure> RspProcedures { get; set; } = new List<RspProcedure>();

    public virtual ICollection<RspReportBasicDetail> RspReportBasicDetails { get; set; } = new List<RspReportBasicDetail>();

    public virtual ICollection<RspReportsVehicleDatum> RspReportsVehicleData { get; set; } = new List<RspReportsVehicleDatum>();

    public virtual ICollection<RspVehicleDatum> RspVehicleData { get; set; } = new List<RspVehicleDatum>();

    public virtual ICollection<SaaedIdamagePartsIntegrationLog> SaaedIdamagePartsIntegrationLogs { get; set; } = new List<SaaedIdamagePartsIntegrationLog>();

    public virtual ICollection<SaaedIplateNumbersIntegrationLog> SaaedIplateNumbersIntegrationLogs { get; set; } = new List<SaaedIplateNumbersIntegrationLog>();

    public virtual ICollection<SaaedIprocessedImage> SaaedIprocessedImages { get; set; } = new List<SaaedIprocessedImage>();

    public virtual ICollection<TrafficViolation> TrafficViolations { get; set; } = new List<TrafficViolation>();

    public virtual ICollection<TransferedReportDocument> TransferedReportDocuments { get; set; } = new List<TransferedReportDocument>();

    public virtual ICollection<TunnelReportBasicDetail> TunnelReportBasicDetails { get; set; } = new List<TunnelReportBasicDetail>();

    public virtual ICollection<UploadedReportStatus> UploadedReportStatuses { get; set; } = new List<UploadedReportStatus>();
}
