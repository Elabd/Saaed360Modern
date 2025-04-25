using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtOrder
{
    public long ActivityId { get; set; }

    public int? CourtOrderCategoryId { get; set; }

    public long? OrganizationPersonId { get; set; }

    public Guid? OrganizationPersonGuid { get; set; }

    public int? CourtOrderSpecialInstructionId { get; set; }

    public int? CourtOrderRecallReasonId { get; set; }

    public int? CourtOrderServiceCautionId { get; set; }

    public int? CourtOrderStatusId { get; set; }

    public int? CourtOrderSignatureMethodId { get; set; }

    public int? CourtOrderProtectionConditionId { get; set; }

    public string? DocketNumber { get; set; }

    public DateTime? IssuingDate { get; set; }

    public DateTime? RecallDate { get; set; }

    public DateTime? RequestDate { get; set; }

    public DateTime? ServedDate { get; set; }

    public DateTime? AttemptedDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CourtOrderCategoryDim? CourtOrderCategory { get; set; }

    public virtual CourtOrderProtectionConditionDim? CourtOrderProtectionCondition { get; set; }

    public virtual CourtOrderRecallReasonDim? CourtOrderRecallReason { get; set; }

    public virtual CourtOrderServiceCautionDim? CourtOrderServiceCaution { get; set; }

    public virtual CourtOrderSignatureMethodDim? CourtOrderSignatureMethod { get; set; }

    public virtual CourtOrderSpecialInstructionDim? CourtOrderSpecialInstruction { get; set; }

    public virtual CourtOrderStatusDim? CourtOrderStatus { get; set; }

    public virtual OrganizationPerson? OrganizationPerson { get; set; }
}
