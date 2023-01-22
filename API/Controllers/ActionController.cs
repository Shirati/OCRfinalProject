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
    public class ActionController : ControllerBase
    {
        private readonly IService<ActionDTO> _action;
        public ActionController(IService<ActionDTO> action)
        {
            _action = action;
        }


        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<ActionDTO>> Get()
        {
            return await _action.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<ActionDTO> Get(int id)
        {
            return await _action.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<ActionDTO> Post([FromBody] ActionModel postModel)
        {
            ActionDTO newOne = new ActionDTO();
            newOne.ActionTypeId = postModel.ActionTypeId;
            newOne.UserId = postModel.UserId;
            newOne.PaymentId = postModel.PaymentId;
            newOne.IsSucceeded = postModel.IsSucceeded;
          
            return await _action.Add(newOne);
        }

        // PUT api/<ActionController>/5
        [HttpPut("{id}")]
        public async Task<ActionDTO> Put([FromBody] ActionModel postModel)
        {
            ActionDTO newOne = new ActionDTO();
            newOne.ActionId = postModel.ActionId;
            newOne.ActionTypeId = postModel.ActionTypeId;
            newOne.UserId = postModel.UserId;
            newOne.PaymentId = postModel.PaymentId;
            newOne.IsSucceeded = postModel.IsSucceeded;
            return await _action.Update(newOne);
        }

        // DELETE api/<ActionController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _action.Delete(id);
        }
    }
}
