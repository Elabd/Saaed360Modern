using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewCustomerObjectionDocument
{
    public string? DocName { get; set; }

    public DateTime? DocDate { get; set; }

    public string? PersonName { get; set; }

    public long ObjectionId { get; set; }

    public string? DocumentExtension { get; set; }
}
