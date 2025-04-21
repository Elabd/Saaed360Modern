using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestSurvey
{
    public long MobileRequestSurveyId { get; set; }

    public long MobileRequestNumber { get; set; }

    public int MobileRequestAnswerId { get; set; }

    public string? UserComment { get; set; }

    public DateTime DateCreated { get; set; }

    public bool IsDeleted { get; set; }

    public virtual MobileRequestSurveryAnswersDim MobileRequestAnswer { get; set; } = null!;

    public virtual MobileRequest MobileRequestNumberNavigation { get; set; } = null!;
}
