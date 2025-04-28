using Application.Abstractions.AuthService;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Saaed360Modern.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{

    public sealed class EfRefreshTokenStore : IRefreshTokenStore
    {
        private readonly IAppDbContext _db;

        public EfRefreshTokenStore(IAppDbContext db) => _db = db;

        public async Task<string> IssueAsync(Guid userId, CancellationToken ct)
        {
            var token = CreateRandomToken();
            _db.RefreshTokens.Add(new RefreshToken
            {
                UserId = userId,
                Token = token,
                ExpiresUtc = DateTime.UtcNow.AddDays(7)
            });
            await _db.SaveChangesAsync(ct);
            return token;
        }

        public async Task<AspnetUser?> ValidateAsync(string token, CancellationToken ct)
        {
            var rt = await _db.RefreshTokens
                              .Include(r => r.User)
                              .SingleOrDefaultAsync(r => r.Token == token, ct);
            return rt is { IsActive: true } ? rt.User : null;
        }

        public async Task<string> RotateAsync(Guid userId, string oldToken, CancellationToken ct)
        {
            var rt = await _db.RefreshTokens.SingleAsync(r => r.Token == oldToken && r.UserId == userId, ct);
            rt.RevokedUtc = DateTime.UtcNow;

            var newToken = await IssueAsync(userId, ct);
            rt.ReplacedByToken = newToken;

            await _db.SaveChangesAsync(ct);
            return newToken;
        }

        private static string CreateRandomToken()
        {
            var bytes = RandomNumberGenerator.GetBytes(32);
            return Convert.ToBase64String(bytes);
        }
    }

}
