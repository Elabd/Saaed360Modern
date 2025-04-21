using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubjectOrganization
{
    public long OrganizationId { get; set; }

    public int? CautionInformationId { get; set; }

    public int? CriminalInvolvementId { get; set; }

    public int? CriminalTraitId { get; set; }

    public int? CriminalTraitActivityId { get; set; }

    public int? CriminalTraitColorId { get; set; }

    public int? CriminalTraitCommunicationId { get; set; }

    public int? CriminalTraitModusOperationId { get; set; }

    public int? CriminalTraitTargetId { get; set; }

    public int? CriminalTraitDressId { get; set; }

    public int? CriminalTraitEthnicityId { get; set; }

    public long? CriminalTraitTattooImageId { get; set; }

    public Guid CriminalTraitTattooImageGuid { get; set; }

    public long? CriminalTraitGraffitiImageId { get; set; }

    public Guid CriminalTraitGraffitiImageGuid { get; set; }

    public int? CriminalTraitHandSignalId { get; set; }

    public long? CriminalTraitTurfLocaitonId { get; set; }

    public Guid CriminalTraitTurfLocaitonGuid { get; set; }

    public int? StatusId { get; set; }

    public string? SubjectIdentificaiton { get; set; }

    public long? StatementId { get; set; }

    public Guid StatementGuid { get; set; }

    public DateTime? StatementDate { get; set; }

    public int StatementIndicator { get; set; }

    public virtual CautionInformationDim? CautionInformation { get; set; }

    public virtual CriminalInvolvementDim? CriminalInvolvement { get; set; }

    public virtual CriminalTraitDim? CriminalTrait { get; set; }

    public virtual CriminalTraitActivityDim? CriminalTraitActivity { get; set; }

    public virtual CriminalTraitColorDim? CriminalTraitColor { get; set; }

    public virtual CriminalTraitCommunicationDim? CriminalTraitCommunication { get; set; }

    public virtual CriminalTraitDressDim? CriminalTraitDress { get; set; }

    public virtual EthnicityDim? CriminalTraitEthnicity { get; set; }

    public virtual Image? CriminalTraitGraffitiImage { get; set; }

    public virtual CriminalTraitHandSignalDim? CriminalTraitHandSignal { get; set; }

    public virtual CriminalTraitModusOperandiDim? CriminalTraitModusOperation { get; set; }

    public virtual CriminalTraitTargetDim? CriminalTraitTarget { get; set; }

    public virtual Image? CriminalTraitTattooImage { get; set; }

    public virtual Location? CriminalTraitTurfLocaiton { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual OrganizationComment? Statement { get; set; }

    public virtual StatusDim? Status { get; set; }
}
