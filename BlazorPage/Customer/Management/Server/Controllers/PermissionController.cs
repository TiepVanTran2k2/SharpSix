using Management.Application.Contracts.Dtos.Permission;
using Management.Application.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Management.Server.Controllers
{
    [Route("api/permission")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _iPermissionService;
        public PermissionController(IPermissionService permissionService)
        {
            _iPermissionService = permissionService;
        }
        [HttpGet("all")]
        public async Task<List<PermissionDto>> GetAllAsync()
        {
            return await _iPermissionService.GetAllAsync();
        }
    }
}
