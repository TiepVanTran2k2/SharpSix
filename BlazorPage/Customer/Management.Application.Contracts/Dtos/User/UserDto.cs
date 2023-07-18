using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.Contracts.Dtos.User
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
    }
}
