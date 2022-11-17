using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security;
using YaelNewProject.Mock;
using YaelNewProject.Repositories.Entities;
using YaelNewProject.Repositories.Interfaces;
using YaelNewProject.Repositories.Repositories;

namespace YaelNewProject.MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermiisionRepository _permissionRepository;

        public PermissionsController(IPermiisionRepository permissionRepository)
        {
            
            _permissionRepository = permissionRepository;
        }

        [HttpGet]
        public List<Permission> Get()
        {
            return _permissionRepository.GetALL();
        }
        [HttpGet("{id}")]
        public Permission GetById(int id)
        {
            return _permissionRepository.GetById(id);
        }
        [HttpPost]
        public Permission AddRole(int id, string name, string descripition)
        {
            return _permissionRepository.Add(id, name, descripition);
        }
        [HttpPut]
        public Permission Update(Permission permission)
        {
            return _permissionRepository.Update(permission);
        }
        [HttpDelete]
        public Permission Delete(int id)
        {
            return _permissionRepository.Delete(id);
        }
    }
}

