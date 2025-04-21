using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsMission
{
    public long MissionId { get; set; }

    public string? MissionNumber { get; set; }

    public string? MissionName { get; set; }

    public DateTime? MissionStartDate { get; set; }

    public DateTime? MissionEndDate { get; set; }

    public int? MissonLevelId { get; set; }

    public long? EventId { get; set; }

    public string? MissionNotes { get; set; }

    public int? CurrentStatusId { get; set; }

    public bool? IsPersonalMission { get; set; }

    public string? MissionTypeDescription { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool? IsDeteted { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public int? MissionCategoryId { get; set; }

    public string? MissionDescription { get; set; }

    public long? ModifiedBy { get; set; }

    public int? EventMissionAcceptanceStatusId { get; set; }

    public long? EventMissionAcceptanceBy { get; set; }

    public DateTime? EventMissionAcceptanceDateTime { get; set; }

    public string? GroupId { get; set; }

    public string? SubGroupId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventsMissionStatusDim? CurrentStatus { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<EventIncident> EventIncidents { get; set; } = new List<EventIncident>();

    public virtual EventMissionAcceptanceStatusDim? EventMissionAcceptanceStatus { get; set; }

    public virtual ICollection<EventsMissionAssignment> EventsMissionAssignments { get; set; } = new List<EventsMissionAssignment>();

    public virtual ICollection<EventsMissionsStatusLog> EventsMissionsStatusLogs { get; set; } = new List<EventsMissionsStatusLog>();

    public virtual ICollection<EventsMissionsType> EventsMissionsTypes { get; set; } = new List<EventsMissionsType>();

    public virtual MissionCategoryDim? MissionCategory { get; set; }

    public virtual EventsMissionLevelDim? MissonLevel { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }
}
