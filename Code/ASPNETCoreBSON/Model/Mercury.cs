using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ASPNETCoreBSON.Model
{
    public class Mercury
    {
        [BsonId]
        public string _id { get; set; }
        public DateTime DateTimeStart { get; set; }
        public double? Hg { get; set; }
        public string unit { get; set; }
    }
}
