using Infrastructure.Persistence.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Auth
{

    public class CurrentUser
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
       
    }

    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public CurrentUser GetCurrentUser()
        {
            var user = _httpContextAccessor.HttpContext?.User;

            if (user == null || !user.Identity.IsAuthenticated)
                return null;

            if (long.TryParse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value, out long userId))
            {
                return new CurrentUser
                {
                    UserId = userId,
                    UserName = user.FindFirst(ClaimTypes.Name)?.Value ?? user.FindFirst("unique_name")?.Value
                    
                };
            }

            return null;
        }
    }
}
