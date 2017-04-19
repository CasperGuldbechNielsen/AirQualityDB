using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Repository
{
    interface IOzonesRepository
    {
        Task Add(Ozone ozoneEntry);
        Task<IEnumerable<Ozone>> GetAll();
        Task<Ozone> Find(string id);
        Task<DeleteResult> Remove(string id);
        Task<UpdateResult> Update(Ozone ozoneEntry);
    }
}
