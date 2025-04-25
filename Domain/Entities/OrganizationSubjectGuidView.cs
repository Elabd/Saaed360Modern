using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationSubjectGuidView
{
    public Guid PersonGuid { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? PersonStatusCode { get; set; }

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

    public string? DnacollectionStatusCode { get; set; }

    public string? CautionInformationCode { get; set; }

    public string? CriminalInvolvementCode { get; set; }

    public string? CriminalTraitCode { get; set; }

    public string? CriminalTraitActivityCode { get; set; }

    public string? CriminalTraitColorCode { get; set; }

    public string? CriminalTraitCommunicationCode { get; set; }

    public string? CriminalTraitDressCode { get; set; }

    public string? CriminalTraitEthnicityCode { get; set; }

    public string? CriminalTraitTargetCode { get; set; }

    public string? CriminalTraitModusOperationCode { get; set; }

    public Guid CriminalTraitTattooImageGuid { get; set; }

    public Guid CriminalTraitGraffitiImageGuid { get; set; }

    public string? CriminalTraitHandSignalCode { get; set; }

    public Guid CriminalTraitTurfLocaitonGuid { get; set; }

    public string? SubjectDisciplinaryActionCode { get; set; }

    public Guid? CriminalOrganizationGuid { get; set; }

    public string? MultiSourceOffenderCode { get; set; }

    public Guid SubjectNoticeGuid { get; set; }

    public Guid StatementGuid { get; set; }

    public string? SubjectStatusCode { get; set; }

    public string? WarrantCategoryCode { get; set; }

    public string? TheftCategoryCode { get; set; }

    public string? SubjectIdentificaiton { get; set; }

    public DateTime? StatementDate { get; set; }

    public int StatementIndicator { get; set; }

    public bool? ArmedIndicator { get; set; }

    public Guid? SubjectSpecialHandlingGuid { get; set; }

    public string? SubjectExtraditionCode { get; set; }

    public string? SubjectCorrectionIdentification { get; set; }

    public string? SubjectJacketNumber { get; set; }

    public Guid OrganizationPersonGuid { get; set; }

    public string OrganizationPersonDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? OrganizationPersonnelCategoryCode { get; set; }

    public string? OrganizationPersonnelRoleCode { get; set; }

    public bool? IsActive { get; set; }
}
