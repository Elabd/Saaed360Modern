using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CurrentUser
    {
        public Guid UserId { get; set; }
        public long PersonId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Guid> Roles { get; set; } = new();
        public List<long> Areas { get; set; } = new();
        public List<long> Organizations { get; set; } = new();

    }
}
