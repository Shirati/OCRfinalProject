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
    public class ActionTypeController : ControllerBase
    {
        private readonly IService<ActionTypeDTO> _actionType;
        public ActionTypeController(IService<ActionTypeDTO> actionType)
        {
            _actionType = actionType;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<ActionTypeDTO>> Get()
        {
            return await _actionType.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<ActionTypeDTO> Get(int id)
        {
            return await _actionType.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<ActionTypeDTO> Post([FromBody] ActionTypeModel postModel)
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
            await _actionType.Delete(id);
        }
    }
}
