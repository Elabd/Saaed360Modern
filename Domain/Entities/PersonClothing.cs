using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonClothing
{
    public long PersonClothingId { get; set; }

    public Guid PersonClothingGuid { get; set; }

    public string PersonClothingDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? PersonClothingCategoryId { get; set; }

    public int? PersonClothingColorId { get; set; }

    public int? PersonClothingStyleId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonClothingCategoryDim? PersonClothingCategory { get; set; }

    public virtual PersonClothingColorDim? PersonClothingColor { get; set; }

    public virtual PersonClothingStyleDim? PersonClothingStyle { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
