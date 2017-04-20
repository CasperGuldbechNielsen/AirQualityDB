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
            try
            {
                var client = new MongoClient(settings.Value.ConnectionString);
                if (settings.Value.IsSsl)
                {
                    settings.Value.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }
                if (client != null)
                    _database = client.GetDatabase(settings.Value.Database);
            }
            catch (Exception e)
            {
                throw new Exception("Can not access to db server." + e.Message);
            }


        }

        public IMongoCollection<Ozzone> Ozones
        {
            get { return _database.GetCollection<Ozzone>("ozoneCollection"); }
        }
    }
}
