using System;
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
    public class OzonesController : Controller
    {
        private readonly IOzonesRepository _ozonesRepository;

        public OzonesController(IOzonesRepository ozonesRepository)
        {
            _ozonesRepository = ozonesRepository;
        }
        
        [NoCache]
        [HttpGet]
        public Task<IEnumerable<Ozone>> Get()
        {
            return GetOzoneInternal();
        }

        private async Task<IEnumerable<Ozone>> GetOzoneInternal()
        {
            return await _ozonesRepository.GetAll();
        }

        // GET api/ozones/5
        [HttpGet("{id}")]
        public Task<Ozone> Get(string id)
        {
            return GetOzoneByIdInternal(id);
        }

        private async Task<Ozone> GetOzoneByIdInternal(string id)
        {
            return await _ozonesRepository.Find(id);
        }

        // POST api/ozones
        [HttpPost]
        public void Post([FromBody]Ozone value)
        {
            //Guid g = Guid.NewGuid();
            //_ozonesRepository.Add(new Ozone() {_id = g.ToString(), DateTimeStart = DateTime.Now, Ozone1 = value, Unit = "ppb"});
            _ozonesRepository.Add(value);
        }

        // PUT api/ozones/5
        [HttpPut("{id}")]
        public void Put([FromBody] Ozone value)
        {
            _ozonesRepository.Update(value);
        }

        // DELETE api/ozones/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _ozonesRepository.Remove(id);
        }
    }
}
