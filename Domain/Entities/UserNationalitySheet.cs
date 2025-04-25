using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UserNationalitySheet
{
    public int Id { get; set; }
    public string? UserId { get; set; }
    public string? Nationality { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public string? ModifiedBy { get; set; }
    public bool? IsDeleted { get; set; }
} 
