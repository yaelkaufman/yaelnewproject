﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelNewProject.Repositories.Entities;
using YaelNewProject.Repositories.Interfaces;

namespace YaelNewProject.Mock
{
    public class MockContext : IcontextRepository
    {
        List<Role> Roles { get; set; }
        List<Claim> Claims { get; set; }
        List<Permission> Permissions { get; set; }
        List<Role> IcontextRepository.Roles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Claim> IcontextRepository.Claims { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Permission> IcontextRepository.Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MockContext()
        {
            Roles=new List<Role>(); 
            Claims=new List<Claim>();
            Permissions=new List<Permission>();


            Roles.Add(new Role { Id = 1, Name = "admin", Description = "full access" });
            Roles.Add(new Role { Id = 2, Name = "student", Description = "student in seminary" });

            Permissions.Add(new Permission { Id = 1, Name = "ViewAllTests", Description = "" });

            Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.Allow });
            Claims.Add(new Claim { Id = 2, RoleId = 2, PermissionId = 1, Policy = EPolicy.Deny });
        }
    }
}
