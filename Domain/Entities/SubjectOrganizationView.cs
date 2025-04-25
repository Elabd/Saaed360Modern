using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubjectOrganizationView
{
    public long OrganizationId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? OrganizationCategoryCode { get; set; }

    public string? OrganizationCategoryDescription { get; set; }

    public string? OrganizationStatusCode { get; set; }

    public string? OrganizationStatusDescription { get; set; }

    public string? Name { get; set; }

    public string? DoingBusinessAs { get; set; }

    public string? Description { get; set; }

    public string? AbbreviationText { get; set; }

    public string? Imonumber { get; set; }

    public DateTime? EstablishedDateTime { get; set; }

    public DateTime? TerminationDateTime { get; set; }

    public bool? IncorporatedIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

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

    public string? CriminalTraitModusOperationCode { get; set; }

    public string? CriminalTraitModusOperationDescription { get; set; }

    public string? CriminalTraitTargetCode { get; set; }

    public string? CriminalTraitTargetDescription { get; set; }

    public string? CriminalTraitDressCode { get; set; }

    public string? CriminalTraitDressDescription { get; set; }

    public string? CriminalTraitEthnicityCode { get; set; }

    public string? CriminalTraitEthnicityDescription { get; set; }

    public long? CriminalTraitTattooImageId { get; set; }

    public long? CriminalTraitGraffitiImageId { get; set; }

    public string? CriminalTraitHandSignalCode { get; set; }

    public string? CriminalTraitHandSignalDescription { get; set; }

    public long? CriminalTraitTurfLocaitonId { get; set; }

    public string? StatusCode { get; set; }

    public string? StatusDescription { get; set; }

    public string? SubjectIdentificaiton { get; set; }

    public long? StatementId { get; set; }

    public DateTime? StatementDate { get; set; }

    public int StatementIndicator { get; set; }
}
