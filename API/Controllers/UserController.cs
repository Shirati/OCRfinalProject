using API.models;
using common.DTOs;
using Microsoft.AspNetCore.Mvc;
using repositories.interfaces;
using Services;
using System.Data;
using Action = repositories.entities.Action;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDTO> _user;

        public UserController(IService<UserDTO> user)
        {
            _user = user;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _user.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _user.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel postModel)
        {
            UserDTO newOne = new UserDTO();
            newOne.PermissionId = postModel.permissionId;
            newOne.AccountId = postModel.accountId; 
            newOne.FirstName = postModel.firstName;
            newOne.LastName = postModel.lastName;
            newOne.Email = postModel.email;
            newOne.Password = postModel.password;
            newOne.Ip = postModel.ip;
            newOne.NumFreeTries = postModel.numFreeTries;
            return await _user.Add(newOne);
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public async Task<UserDTO> Put([FromBody] UserModel postModel)
        {
            UserDTO newOne = new UserDTO();
            newOne.UserId = postModel.userId;
            newOne.PermissionId = postModel.permissionId;
            newOne.AccountId = postModel.accountId;
            newOne.FirstName = postModel.firstName;
            newOne.LastName = postModel.lastName;
            newOne.Email = postModel.email;
            newOne.Password = postModel.password;
            newOne.Ip = postModel.ip;
            newOne.NumFreeTries = postModel.numFreeTries;
            return await _user.Update(newOne);
        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _user.Delete(id);
        }
    }
}
