using Application.DTOs;

namespace Application.Abstractions
{
    public interface ICurrentUserService
    {
        Task<CurrentUser?> GetCurrentUserAsync();
    }
}
