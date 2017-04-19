using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Repository;
using ASPNETCoreBSON.Model;
using ASPNETCoreBSON.Infrastrucure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNETCoreBSON.Controllers
{
    [Route("api/[controller]")]
    public class MercuriesController : Controller
    {
        private readonly IMercuriesRepository _mercuriesRepository;

        public MercuriesController(IMercuriesRepository mercuriesRepository)
        {
            _mercuriesRepository = mercuriesRepository;
        }

        [NoCache]
        [HttpGet]
        public Task<IEnumerable<Mercury>> Get()
        {
            return GetMercuryInternal();
        }

        private async Task<IEnumerable<Mercury>> GetMercuryInternal()
        {
            return await _mercuriesRepository.GetAll();
        }

        // GET api/mercuries/5
        [HttpGet("{id}")]
        public Task<Mercury> Get(string id)
        {
            return GetMercuryByIdInternal(id);
        }

        private async Task<Mercury> GetMercuryByIdInternal(string id)
        {
            return await _mercuriesRepository.Find(id);
        }


        // POST api/mercuries
        [HttpPost]
        public void Post([FromBody] Mercury value)
        {
            _mercuriesRepository.Add(value);
        }

        // PUT api/mercuries/5
        [HttpPut("{id}")]
        public void Put([FromBody] Mercury value)
        {
            _mercuriesRepository.Update(value);
        }

        // DELETE api/mercuries/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _mercuriesRepository.Remove(id);
        }
    }
}
