using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DataMaskingDemo
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public long Age { get; set; }
}
