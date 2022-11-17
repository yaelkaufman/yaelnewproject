using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaelNewProject.Repositories.Entities;
using YaelNewProject.Repositories.Interfaces;

namespace YaelNewProject.MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RolesController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetALL();
        }
        [HttpGet("id")]
        public Role GetByID(int id)
        {
            return _roleRepository.GetById(id);
        }
        [HttpPost]
        public Role Add(int id,string name,string description)
        {
           return _roleRepository.Add(id,name,description);
        }
        [HttpPut("id")]
        public Role Update(Role role)
        {
            return _roleRepository.Update(role);
        }
        [HttpDelete("id")]
        public Role Delete(int id)
        {
            return _roleRepository.Delete(id);
        }
    }
}
