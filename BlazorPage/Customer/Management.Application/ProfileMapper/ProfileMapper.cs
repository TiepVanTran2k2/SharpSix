using AutoMapper;
using Management.Application.Contracts.Dtos.Permission;
using Management.Domain.Entity.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.ProfileMapper
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Permission, PermissionDto>().ReverseMap();
        }
    }
}
