using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Application.Helpers;

namespace Application.Services.Auth;

public class AuthService
{
    private readonly ApplicationDbContext _context;

    public AuthService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<(bool isValid, Guid? userId)> ValidateUserCredentials(string username, string password)
    {
        var user = await _context.AspnetUsers
            .Include(u => u.AspnetMembership)
            .FirstOrDefaultAsync(u => u.LoweredUserName == username.ToLower());

        if (user == null || user.AspnetMembership == null)
        {
            return (false, null);
        }

        var isValid = VerifyPassword(password, 
            user.AspnetMembership.Password, 
            user.AspnetMembership.PasswordSalt, 
            user.AspnetMembership.PasswordFormat) && 
            user.AspnetMembership.IsApproved && 
            !user.AspnetMembership.IsLockedOut;

        return (isValid, isValid ? user.UserId : null);
    }

    private bool VerifyPassword(string password, string hashedPassword, string salt, int passwordFormat)
    {
        if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hashedPassword) || string.IsNullOrEmpty(salt))
            return false;

        string computedHash;
        switch (passwordFormat)
        {
            case 0: // Clear text (not recommended)
                computedHash = password;
                break;
            case 1: // Hashed
                computedHash = HashHelper.GenerateHash(password, salt);
                break;
            default:
                return false;
        }

        return hashedPassword.Equals(computedHash, StringComparison.Ordinal);
    }
} 