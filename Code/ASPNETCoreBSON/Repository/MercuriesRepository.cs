using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Repository
{
    public class MercuriesRepository : IMercuriesRepository
    {
        public async Task Add(Mercury mercuryEntry)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Mercury>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Mercury> Find(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<DeleteResult> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<UpdateResult> Update(Mercury mercuryEntry)
        {
            throw new NotImplementedException();
        }
    }
}
