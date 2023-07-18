using Management.Domain.Entity.Role;
using Management.EntityFrameworkCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.EntityFrameworkCore.Repository
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(DbContextApp dbContextApp) : base(dbContextApp)
        {
        }
    }
}
