using AutoMapper;
using Management.Application.Contracts.Dtos.Permission;
using Management.Application.Contracts.Services;
using Management.Domain.Entity.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.Applications
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _iPermissionRepository;
        private readonly IMapper _iMapper;
        public PermissionService(IPermissionRepository permissionRepository,
                                 IMapper mapper)
        {
            _iPermissionRepository = permissionRepository;
            _iMapper = mapper;
        }
        public async Task<bool> CreateAsync(PermissionDto input)
        {
            var data = _iMapper.Map<Permission>(input);
            var check = (await _iPermissionRepository.GetQueryableAsync()).Where(x => x.Name.Equals(input.Name))
                                                                          .FirstOrDefault();
            if(check != null)
            {
                return false;
            }
            await _iPermissionRepository.InsertAsync(data);
            return true;
        }

        public async Task<List<PermissionDto>> GetAllAsync()
        {
            var listPermission = await _iPermissionRepository.TolistAsync();
            var result = _iMapper.Map<List<PermissionDto>>(listPermission);
            return result;
        }
    }
}
