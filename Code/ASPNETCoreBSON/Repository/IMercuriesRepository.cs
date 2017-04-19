using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Repository
{
    public interface IMercuriesRepository
    {
        Task Add(Mercury mercuryEntry);
        Task<IEnumerable<Mercury>> GetAll();
        Task<Mercury> Find(string id);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(Mercury mercuryEntry);
    }
}
