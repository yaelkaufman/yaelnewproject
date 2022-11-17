using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelNewProject.Repositories.Entities;

namespace YaelNewProject.Repositories.Interfaces
{
    public interface IcontextRepository
    {
        List<Role> Roles { get; set; }
        List<Claim> Claims { get; set; }
        List<Permission> Permissions { get; set; }

    }
}
