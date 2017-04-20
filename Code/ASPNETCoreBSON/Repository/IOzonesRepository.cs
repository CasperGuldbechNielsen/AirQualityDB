using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Repository
{
    public interface IOzonesRepository
    {
        Task Add(Ozzone ozzoneEntry);
        Task<IEnumerable<Ozzone>> GetAll();
        Task<Ozzone> Find(string id);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(Ozzone ozzoneEntry);
    }
}
