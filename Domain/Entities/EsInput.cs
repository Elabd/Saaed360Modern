using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsInput
{
    public int Id { get; set; }

    public int Index { get; set; }

    public int ServiceId { get; set; }

    public int TypeId { get; set; }

    public string Code { get; set; } = null!;

    public string NameArabic { get; set; } = null!;

    public string NameEnglish { get; set; } = null!;

    public string NameUrdu { get; set; } = null!;

    public string RequestDataBind { get; set; } = null!;

    public string? InputGroup { get; set; }

    public string? Placeholder { get; set; }

    public bool IsRequired { get; set; }

    public int? ConditionId { get; set; }

    public string? ConditionValue { get; set; }

    public int? SelectorConditionId { get; set; }

    public int? ValidationMinLength { get; set; }

    public int? ValidationMaxLength { get; set; }

    public string? ValidationPattern { get; set; }

    public DateTime CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public virtual EsConditionDim? Condition { get; set; }

    public virtual EsConditionDim? SelectorCondition { get; set; }

    public virtual EsService Service { get; set; } = null!;

    public virtual EsInputTypeDim Type { get; set; } = null!;
}
