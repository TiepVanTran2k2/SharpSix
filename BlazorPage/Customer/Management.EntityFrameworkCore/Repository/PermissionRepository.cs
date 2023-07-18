using Management.Domain.Entity.Permission;
using Management.EntityFrameworkCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.EntityFrameworkCore.Repository
{
    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(DbContextApp dbContextApp) : base(dbContextApp)
        {
        }
    }
}
