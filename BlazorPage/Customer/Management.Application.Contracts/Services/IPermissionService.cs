using Management.Application.Contracts.Dtos.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.Contracts.Services
{
    public interface IPermissionService
    {
        Task<bool> CreateAsync(PermissionDto input);
    }
}
