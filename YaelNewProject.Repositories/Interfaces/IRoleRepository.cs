using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelNewProject.Repositories.Entities;

namespace YaelNewProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> GetALL();
        Role GetById(int id);
        Role Add(int id, string name, string description);
        Role Update(Role role);
        Role Delete(int id);
    }
}
