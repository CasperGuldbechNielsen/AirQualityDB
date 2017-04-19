using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Contexts
{
    public class MercuriesContext
    {
        private readonly IMongoDatabase _database = null;

        public MercuriesContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
            
        }

        public IMongoCollection<Mercury> Mercuries
        {
            get { return _database.GetCollection<Mercury>("mercuryCollection"); }
        }
    }
}
