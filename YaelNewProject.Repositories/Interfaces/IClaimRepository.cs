using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelNewProject.Repositories.Entities;

namespace YaelNewProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAll();
        Claim GetById(int id);
        Claim Add(int id,int RoleID,int PermissionID,EPolicy policy);
        Claim Update(Claim claim);
        Claim Delete(int id);


    }
}
