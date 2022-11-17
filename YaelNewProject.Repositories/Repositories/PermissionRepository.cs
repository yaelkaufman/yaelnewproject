using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelNewProject.Repositories.Entities;
using YaelNewProject.Repositories.Interfaces;

namespace YaelNewProject.Repositories.Repositories
{
    public class PermissionRepository : IPermiisionRepository
         
    {
        private readonly IcontextRepository _context;
        public PermissionRepository(IcontextRepository context)
        {
            _context = context;
        }

        public Permission Add(int id, string name, string description)
        {
            _context.Permissions.Add(new Permission { Id=id, Name=name, Description=description });
            return _context.Permissions.First(p=>p.Id==id);
        }

        public Permission Delete(int id)
        {
            Permission p = _context.Permissions.First(p=>p.Id==id);
            _context.Permissions.Remove(p);
            return p;

        }

        public List<Permission> GetALL()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            Permission p= _context.Permissions.First(p=>p.Id==id);
            return p;
        }

        public Permission Update(Permission permission)
        {
           Permission p=_context.Permissions.First(p=>p.Id==permission.Id);
            p.Id=permission.Id;
            p.Name=permission.Name;
            p.Description=permission.Description;
            return p;
        }
    }
}
