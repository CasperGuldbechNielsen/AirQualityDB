using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;

namespace ASPNETCoreBSON.Repository
{
    interface IOzonesRepository
    {
        void Add(Ozone ozoneEntry);
        IEnumerable<Ozone> GetAll();
        Ozone Find(string id);
        void Remove(string id);
        void Update(Ozone ozoneEntry);
    }
}
