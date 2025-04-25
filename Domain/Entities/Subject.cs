using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Subject
{
    public long PersonId { get; set; }

    public int? DnacollectionStatusId { get; set; }

    public int? CautionInformationId { get; set; }

    public int? CriminalInvolvementId { get; set; }

    public int? CriminalTraitId { get; set; }

    public int? CriminalTraitActivityId { get; set; }

    public int? CriminalTraitColorId { get; set; }

    public int? CriminalTraitCommunicationId { get; set; }

    public int? CriminalTraitDressId { get; set; }

    public int? CriminalTraitEthnicityId { get; set; }

    public int? CriminalTraitTargetId { get; set; }

    public int? CriminalTraitModusOperationId { get; set; }

    public long? CriminalTraitTattooImageId { get; set; }

    public Guid CriminalTraitTattooImageGuid { get; set; }

    public long? CriminalTraitGraffitiImageId { get; set; }

    public Guid CriminalTraitGraffitiImageGuid { get; set; }

    public int? CriminalTraitHandSignalId { get; set; }

    public long? CriminalTraitTurfLocaitonId { get; set; }

    public Guid CriminalTraitTurfLocaitonGuid { get; set; }

    public int? SubjectDisciplinaryActionId { get; set; }

    public long? CriminalOrganizationId { get; set; }

    public Guid? CriminalOrganizationGuid { get; set; }

    public int? MultiSourceOffenderId { get; set; }

    public long? SubjectNoticeId { get; set; }

    public Guid SubjectNoticeGuid { get; set; }

    public long? StatementId { get; set; }

    public Guid StatementGuid { get; set; }

    public int? SubjectStatusId { get; set; }

    public int? WarrantCategoryId { get; set; }

    public int? TheftCategoryId { get; set; }

    public string? SubjectIdentificaiton { get; set; }

    public DateTime? StatementDate { get; set; }

    public int StatementIndicator { get; set; }

    public bool? ArmedIndicator { get; set; }

    public long? SubjectSpecialHandlingId { get; set; }

    public Guid? SubjectSpecialHandlingGuid { get; set; }

    public int? SubjectExtraditionId { get; set; }

    public string? SubjectCorrectionIdentification { get; set; }

    public string? SubjectJacketNumber { get; set; }

    public virtual CautionInformationDim? CautionInformation { get; set; }

    public virtual CriminalInvolvementDim? CriminalInvolvement { get; set; }

    public virtual Organization? CriminalOrganization { get; set; }

    public virtual CriminalTraitDim? CriminalTrait { get; set; }

    public virtual CriminalTraitActivityDim? CriminalTraitActivity { get; set; }

    public virtual CriminalTraitColorDim? CriminalTraitColor { get; set; }

    public virtual CriminalTraitCommunicationDim? CriminalTraitCommunication { get; set; }

    public virtual CriminalTraitDressDim? CriminalTraitDress { get; set; }

    public virtual EthnicityDim? CriminalTraitEthnicity { get; set; }

    public virtual PersonImage? CriminalTraitGraffitiImage { get; set; }

    public virtual CriminalTraitHandSignalDim? CriminalTraitHandSignal { get; set; }

    public virtual CriminalTraitModusOperandiDim? CriminalTraitModusOperation { get; set; }

    public virtual CriminalTraitTargetDim? CriminalTraitTarget { get; set; }

    public virtual PersonImage? CriminalTraitTattooImage { get; set; }

    public virtual PersonLocation? CriminalTraitTurfLocaiton { get; set; }

    public virtual DnacollectionStatusDim? DnacollectionStatus { get; set; }

    public virtual MultiSourceOffenderDim? MultiSourceOffender { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonComment? Statement { get; set; }

    public virtual SubjectDisciplinaryActionDim? SubjectDisciplinaryAction { get; set; }

    public virtual SubjectExtraditionDim? SubjectExtradition { get; set; }

    public virtual PersonComment? SubjectNotice { get; set; }

    public virtual PersonComment? SubjectSpecialHandling { get; set; }

    public virtual SubjectStatusDim? SubjectStatus { get; set; }

    public virtual TheftCategoryDim? TheftCategory { get; set; }

    public virtual WarrantCategoryDim? WarrantCategory { get; set; }
}
