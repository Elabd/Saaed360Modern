using Application.DTOs.Auth;

public class LoginResponse
{
    public string AccessToken { get; set; }
    public DateTime AccessTokenExpiration { get; set; }

    // RefreshToken and RefreshTokenExpiration removed - will be handled via HttpOnly cookie

    public UserInfoDto User { get; set; }
}