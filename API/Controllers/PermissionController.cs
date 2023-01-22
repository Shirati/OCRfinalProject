using API.models;
using common.DTOs;
using Microsoft.AspNetCore.Mvc;
using repositories.entities;
using repositories.interfaces;
using Services;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IService<PermissionDTO> _permission;
        public PermissionController(IService<PermissionDTO> permission)
        {
            _permission = permission;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<PermissionDTO>> Get()
        {
            return await _permission.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<PermissionDTO> Get(int id)
        {
            return await _permission.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<PermissionDTO> Post([FromBody] PermissionModel postModel)
        {
            PermissionDTO newOne = new PermissionDTO();
            newOne.PremissionName = postModel.premissionName;
            return await _permission.Add(newOne);
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public async Task<PermissionDTO> Put([FromBody] PermissionModel postModel)
        {
            PermissionDTO newOne = new PermissionDTO();
            newOne.PermissionId = postModel.permissionId;
            newOne.PremissionName = postModel.premissionName;
            return await _permission.Update(newOne);

        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _permission.Delete(id);
        }
    }
}
