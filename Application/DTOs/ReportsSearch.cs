namespace Application.DTOs
{
    public class ReportsSearch
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? StatusId { get; set; }
        public int? AreaId { get; set; }
        public int? ObjectionEmirateId { get; set; }
        public int? RequestTypeId { get; set; }
        public string ReportNumber { get; set; }
        public string RequestNumber { get; set; }
    }
} 