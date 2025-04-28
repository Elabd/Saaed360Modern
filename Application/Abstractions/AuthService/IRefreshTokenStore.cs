using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.AuthService
{
    public interface IRefreshTokenStore
    {
        Task<string> IssueAsync(Guid userId, CancellationToken ct);
        Task<AspnetUser?> ValidateAsync(string token, CancellationToken ct);
        Task<string> RotateAsync(Guid userId, string oldToken, CancellationToken ct);
    }
}
