using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Management.Domain.Entity.Role
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Permission.Permission> Permissions { get; set; }
    }
}
