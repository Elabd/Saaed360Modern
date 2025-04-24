using System;
using System.Collections.Generic;

namespace Application.DTOs
{
    public class SearchObjectionDTO
    {
        public SearchObjectionDTO()
        {
            areaId = new List<long>();
            UserareaIds = new List<long>();
        }
        public DateTime? from { get; set; }
        public DateTime? to { get; set; }
        public int? statusId { get; set; }
        public int? typeId { get; set; }
        public string? ReportNumber { get; set; }
        public List<long> areaId { get; set; }
        public long RequestNumber { get; set; }
        public string? UserName { get; set; }
        public long? UserId { get; set; }
        public List<long> UserareaIds { get; set; }
        public int? EmirateId { get; set; }
    }
} 