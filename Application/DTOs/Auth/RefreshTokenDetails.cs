using System;

namespace Application.DTOs.Auth
{
    /// <summary>
    /// Internal details for the refresh token, used for setting the cookie.
    /// Not intended to be returned directly to the client in the response body.
    /// </summary>
    public class RefreshTokenDetails
    {
        public required string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}

