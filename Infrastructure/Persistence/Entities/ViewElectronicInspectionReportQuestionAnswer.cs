using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewElectronicInspectionReportQuestionAnswer
{
    public long ReportId { get; set; }

    public long ReportAnswerId { get; set; }

    public long QuestionId { get; set; }

    public string QuestionName { get; set; } = null!;

    public long AnswerId { get; set; }

    public string AnswerName { get; set; } = null!;

    public string? Comment { get; set; }

    public Guid? Fmscode { get; set; }
}
