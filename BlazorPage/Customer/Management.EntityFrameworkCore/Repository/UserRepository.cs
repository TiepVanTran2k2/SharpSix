using Management.Domain.Entity.User;
using Management.Domain.Repository;
using Management.EntityFrameworkCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.EntityFrameworkCore.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DbContextApp dbContextApp) : base(dbContextApp)
        {
        }
    }
}
