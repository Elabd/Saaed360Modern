using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivitySubjectView
{
    public long PersonId { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? PersonStatusCode { get; set; }

    public string? PersonStatusDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Moniker { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public int? PersonCategoryId { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public string? DnacollectionStatusCode { get; set; }

    public string? DnacollectionStatusDescription { get; set; }

    public string? CautionInformationCode { get; set; }

    public string? CautionInformationDescription { get; set; }

    public string? CriminalInvolvementCode { get; set; }

    public string? CriminalInvolvementDescription { get; set; }

    public string? CriminalTraitCode { get; set; }

    public string? CriminalTraitDescription { get; set; }

    public string? CriminalTraitActivityCode { get; set; }

    public string? CriminalTraitActivityDescription { get; set; }

    public string? CriminalTraitColorCode { get; set; }

    public string? CriminalTraitColorDescription { get; set; }

    public string? CriminalTraitCommunicationCode { get; set; }

    public string? CriminalTraitCommunicationDescription { get; set; }

    public string? CriminalTraitDressCode { get; set; }

    public string? CriminalTraitDressDescription { get; set; }

    public string? CriminalTraitEthnicityCode { get; set; }

    public string? CriminalTraitEthnicityDescription { get; set; }

    public string? CriminalTraitTargetCode { get; set; }

    public string? CriminalTraitTargetDescription { get; set; }

    public string? CriminalTraitModusOperationCode { get; set; }

    public string? CriminalTraitModusOperationDescription { get; set; }

    public long? CriminalTraitTattooImageId { get; set; }

    public long? CriminalTraitGraffitiImageId { get; set; }

    public string? CriminalTraitHandSignalCode { get; set; }

    public string? CriminalTraitHandSignalDescription { get; set; }

    public long? CriminalTraitTurfLocaitonId { get; set; }

    public string? SubjectDisciplinaryActionCode { get; set; }

    public string? SubjectDisciplinaryActionDescription { get; set; }

    public long? CriminalOrganizationId { get; set; }

    public string? MultiSourceOffenderCode { get; set; }

    public string? MultiSourceOffenderDescription { get; set; }

    public long? SubjectNoticeId { get; set; }

    public long? StatementId { get; set; }

    public string? SubjectStatusCode { get; set; }

    public string? SubjectStatusDescription { get; set; }

    public string? WarrantCategoryCode { get; set; }

    public string? WarrantCategoryDescription { get; set; }

    public string? TheftCategoryCode { get; set; }

    public string? TheftCategoryDescription { get; set; }

    public string? SubjectIdentificaiton { get; set; }

    public DateTime? StatementDate { get; set; }

    public int StatementIndicator { get; set; }

    public bool? ArmedIndicator { get; set; }

    public long? SubjectSpecialHandlingId { get; set; }

    public string? SubjectExtraditionCode { get; set; }

    public string? SubjectExtraditionDescription { get; set; }

    public string? SubjectCorrectionIdentification { get; set; }

    public string? SubjectJacketNumber { get; set; }

    public long ActivityPersonId { get; set; }

    public string ActivityPersonDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? PersonInvolvementDescription { get; set; }
}
