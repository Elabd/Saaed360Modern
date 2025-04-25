using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundOrdersOpenedView
{
    public long OrderId { get; set; }

    public string? OrderNumber { get; set; }

    public string CustomerMobileNumber { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public int OrderPriority { get; set; }

    public int AreaId { get; set; }

    public int AuthorityId { get; set; }

    public DateTime CreatedDatetime { get; set; }

    public string? VehicleStatus { get; set; }

    public int? OrderStatus { get; set; }

    public double SourceLatitude { get; set; }

    public double SourceLongitude { get; set; }

    public string ImpoundOrderStatus { get; set; } = null!;

    public string ImpoundPriority { get; set; } = null!;

    public long? Id { get; set; }

    public int? ImpoundTypeId { get; set; }

    public string? ImpoundReasonDescription { get; set; }

    public int? ImpoundReasonId { get; set; }

    public bool? IsVehicle { get; set; }

    public double? DestinationLatitude { get; set; }

    public double? DestinationLongitude { get; set; }

    public int? VehicleTypeId { get; set; }

    public int? StatusId { get; set; }

    public long? PatrolId { get; set; }

    public long? DispatchedPersonId { get; set; }

    public DateTime? DispatchedTime { get; set; }

    public long? DispatcherId { get; set; }

    public string? PatrolCode { get; set; }

    public string DispatchedPersonName { get; set; } = null!;

    public string DispatcherName { get; set; } = null!;
}
