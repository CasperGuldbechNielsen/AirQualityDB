using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Contexts
{
    public class OzonesContext
    {
        private readonly IMongoDatabase _database = null;

        public OzonesContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Ozone> Ozones
        {
            get { return _database.GetCollection<Ozone>("ozoneCollection"); }
        }
    }
}
