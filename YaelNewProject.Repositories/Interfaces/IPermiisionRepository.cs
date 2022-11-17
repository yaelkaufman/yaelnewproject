using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelNewProject.Repositories.Entities;

namespace YaelNewProject.Repositories.Interfaces
{
    public interface IPermiisionRepository
    {
        List<Permission> GetALL();
        Permission GetById(int id);
        Permission Add(int id,string name,string description);
        Permission Update(Permission permission);
        Permission Delete(int id);
    }
}
