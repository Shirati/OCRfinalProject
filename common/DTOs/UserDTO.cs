using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public int? PermissionId { get; set; }

        public string? Ip { get; set; }

        public int? AccountId { get; set; }

        public int? NumFreeTries { get; set; }
    }
}
