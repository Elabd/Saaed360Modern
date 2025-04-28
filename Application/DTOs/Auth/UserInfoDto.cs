namespace Application.DTOs.Auth
{
    public class UserInfoDto
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
