using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileUser
{
    public long MobileUserId { get; set; }

    public string? Tcn { get; set; }

    public string Username { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public long? RegisterationRequestId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletionDate { get; set; }

    public string? UaepassUuid { get; set; }

    public int? NationalityId { get; set; }

    public string? Nationality { get; set; }

    public int? GenderId { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? IdentityEmiratesId { get; set; }

    public int? LanguageId { get; set; }

    public int? CommunicationChannelId { get; set; }

    public long? EmirateId { get; set; }

    public long? CityId { get; set; }

    public long? AreaId { get; set; }

    public string? DetailedAddress { get; set; }

    public bool MobileVerified { get; set; }

    public bool EnforcePasswordChange { get; set; }

    public DateTime PasswordExpirationDate { get; set; }

    public string? HistoricalTrackingHashedPassword { get; set; }

    public int PasswordChangeAttemptsCount { get; set; }

    public string? Salt { get; set; }

    public DateTime PasswordChangeDate { get; set; }

    public virtual Area? Area { get; set; }

    public virtual CityDim? City { get; set; }

    public virtual CommunicationMethodsDim? CommunicationChannel { get; set; }

    public virtual EmirateDim? Emirate { get; set; }

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();

    public virtual ICollection<ExternalUserPasswordChangeHistory> ExternalUserPasswordChangeHistories { get; set; } = new List<ExternalUserPasswordChangeHistory>();

    public virtual GenderDim? Gender { get; set; }

    public virtual LanguageDim? Language { get; set; }

    public virtual NationalityDim? NationalityNavigation { get; set; }

    public virtual MobileRegistrationUserRequest? RegisterationRequest { get; set; }
}
