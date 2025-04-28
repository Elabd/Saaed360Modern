using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    // Domain.Entities
    public sealed class RefreshToken
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public Guid UserId { get; init; }
        public string Token { get; init; } = default!;
        public DateTime ExpiresUtc { get; init; }
        public DateTime CreatedUtc { get; init; } = DateTime.UtcNow;
        public DateTime? RevokedUtc { get; set; }
        public string? ReplacedByToken { get; set; }

        // navigation

        public AspnetUser User { get; set; } = null!; // Removed 'virtual' keyword to fix CS0549
        public bool IsActive => RevokedUtc == null && DateTime.UtcNow < ExpiresUtc;
    }


}
