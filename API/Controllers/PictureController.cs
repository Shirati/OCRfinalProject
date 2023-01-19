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
    public class PictureController : ControllerBase
    {
        private readonly IService<PictureDTO> _picture;
        public PictureController(IService<PictureDTO> picture)
        {
            _picture = picture;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<PictureDTO>> Get()
        {
            return await _picture.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<PictureDTO> Get(int id)
        {
            return await _picture.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<PictureDTO> Post([FromBody] PictureModel postModel)
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
            await _picture.Delete(id);
        }
    }
}
