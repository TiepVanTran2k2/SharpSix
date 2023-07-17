using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Management.Domain.Entity.User
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public Role.Role Role { get; set; }
    }
}
