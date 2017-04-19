using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Repository
{
    public class OzonesRepository: IOzonesRepository
    {
        public async Task Add(Ozone ozoneEntry)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ozone>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Ozone> Find(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<DeleteResult> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<UpdateResult> Update(Ozone ozoneEntry)
        {
            throw new NotImplementedException();
        }
    }
}
