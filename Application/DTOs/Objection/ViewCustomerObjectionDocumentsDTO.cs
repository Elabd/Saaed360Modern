namespace Application.DTOs.Objection
{
    public class ViewCustomerObjectionDocumentsDTO
    {
        public string CreationTime { get; set; }
        public string DocName { get; set; }

        public string DocPath { get; set; }
        public long ObjectionId { get; set; }
        public string PersonName { get; set; }
        public string Type { get; set; }
    }
}