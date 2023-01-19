using API.models;
using common.DTOs;
using Microsoft.AspNetCore.Mvc;
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
            throw new NotImplementedException();
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();

        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _permission.Delete(id);
        }
    }
}
