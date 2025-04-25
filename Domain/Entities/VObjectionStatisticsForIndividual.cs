using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VObjectionStatisticsForIndividual
{
    public long ObjectionId { get; set; }

    public int? RequestTypeId { get; set; }

    public int StatusId { get; set; }

    public long? EmiratesId { get; set; }

    public DateTime ObjectionDate { get; set; }

    public int? LogStatusId { get; set; }

    public long? PersonId { get; set; }

    public DateTime? LogDateTime { get; set; }
}
