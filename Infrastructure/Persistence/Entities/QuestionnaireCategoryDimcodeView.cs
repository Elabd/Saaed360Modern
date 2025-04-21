using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class QuestionnaireCategoryDimcodeView
{
    public string? QuestionnaireCategoryDescription { get; set; }

    public string? QuestionnaireCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
