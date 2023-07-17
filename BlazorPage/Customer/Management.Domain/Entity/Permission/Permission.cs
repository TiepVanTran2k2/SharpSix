using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Entity.Permission
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Role.Role> Roles { get; set;}
    }
}
