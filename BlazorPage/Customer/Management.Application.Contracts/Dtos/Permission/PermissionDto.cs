using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.Contracts.Dtos.Permission
{
    public class PermissionDto
    {
        [Required]
        public string Name { get; set; }
    }
}
