using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaelNewProject.Mock;
using YaelNewProject.Repositories.Entities;
using YaelNewProject.Repositories.Interfaces;
using YaelNewProject.Repositories.Repositories;

namespace YaelNewProject.MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimsController(IClaimRepository claimRepository)
        {
            
            _claimRepository = claimRepository;
        }

        [HttpGet]
        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            return _claimRepository.GetById(id);
        }
        [HttpPost]
        public Claim AddClaim(int id, int RoleId, int PermissionId, EPolicy Policy)
        {
            return _claimRepository.Add(id, RoleId, PermissionId, Policy);
        }
        [HttpPut]
        public Claim Update(Claim claim)
        {
            return _claimRepository.Update(claim);
        }
        [HttpDelete]
        public Claim Delete(int id)
        {
            return _claimRepository.Delete(id);
        }

    }
}


