using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonClothingCategoryDim
{
    public int PersonClothingCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonClothing> PersonClothings { get; set; } = new List<PersonClothing>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
