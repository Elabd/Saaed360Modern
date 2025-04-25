using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionnaireCategoryDimcodeView
{
    public string? QuestionnaireCategoryDescription { get; set; }

    public string? QuestionnaireCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
