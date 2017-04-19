using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Model
{
    public class Settings : MongoClientSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
        public bool IsSsl { get; set; }
    }
}
