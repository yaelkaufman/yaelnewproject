using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelNewProject.Repositories.Entities;
using YaelNewProject.Repositories.Interfaces;

namespace YaelNewProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IcontextRepository _context;


        public RoleRepository(IcontextRepository context)
        {
            _context = context;
        }

        public Role Add(int id, string name, string description)
        {
            _context.Roles.Add(new Role { Id = id, Name = name, Description = description });
            return _context.Roles.First(p => p.Id == id);
        }

        public Role Delete(int id)
        {
            Role r = _context.Roles.First(p1 => p1.Id == id);
            _context.Roles.Remove(r);
            //_context.Roles= _context.Roles.Where(p1 => p1.Id != id).ToList();
            return r;
        }


        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public List<Role> GetALL()
        {
            throw new NotImplementedException();
        }

        public Role GetById(int id)
        {
            return _context.Roles.First(p => p.Id == id);
        }

        public Role Update(Role role)
        {
            Role r = _context.Roles.First(p => p.Id == role.Id);
            r.Name = role.Name;
            r.Description = role.Description;
            return r;
        }


    }
}

