using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentTransaction
{
    public long TransactionId { get; set; }

    public int? ReportVehicleDataId { get; set; }

    public int? PaymentRequestTypeId { get; set; }

    public long? ObjectionId { get; set; }

    public double? NetAmount { get; set; }

    public double? PaymentGatewayFees { get; set; }

    public double? TotalAmount { get; set; }

    public int? PaymentStatusId { get; set; }

    public int? PaymentUserAccountId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public string? PayProPaymentReference { get; set; }

    public string? PayProRefundReference { get; set; }

    public bool? IsSetteled { get; set; }

    public DateTime? SettlementDate { get; set; }

    public string? SaaedPaymentReference { get; set; }

    public int? ServiceStatus { get; set; }

    public DateTime? PaymentDate { get; set; }

    public long? RequestId { get; set; }

    public double? ServiceAmount { get; set; }

    public double? Vat { get; set; }

    public long? PaymentInfoId { get; set; }

    public bool? IsWallet { get; set; }

    public short? PaymentMethod { get; set; }

    public int? ChannelId { get; set; }

    public virtual ObjectionRequestChannelDim? Channel { get; set; }

    public virtual Objection? Objection { get; set; }

    public virtual ICollection<PaymentChannelReturnPage> PaymentChannelReturnPages { get; set; } = new List<PaymentChannelReturnPage>();

    public virtual PaymentOrganizationInfo? PaymentInfo { get; set; }

    public virtual ICollection<PaymentIntegrationLog> PaymentIntegrationLogs { get; set; } = new List<PaymentIntegrationLog>();

    public virtual ICollection<PaymentRefundDetail> PaymentRefundDetails { get; set; } = new List<PaymentRefundDetail>();

    public virtual PaymentRequestTypeDim? PaymentRequestType { get; set; }

    public virtual ICollection<PaymentSettlementTransaction> PaymentSettlementTransactions { get; set; } = new List<PaymentSettlementTransaction>();

    public virtual PaymentRequestStatusDim? PaymentStatus { get; set; }

    public virtual PaymentUserAccount? PaymentUserAccount { get; set; }

    public virtual ReportVehicleDatum? ReportVehicleData { get; set; }
}
