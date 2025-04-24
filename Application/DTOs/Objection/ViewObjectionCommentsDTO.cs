namespace Application.DTOs.Objection
{
    public class ViewObjectionCommentsDTO
    {
        public string CommentText { get; set; }
        public string CreationTime { get; set; }
        public long ObjectionId { get; set; }
        public long PersonId { get; set; }
        public string PersonName { get; set; }
    }
}

