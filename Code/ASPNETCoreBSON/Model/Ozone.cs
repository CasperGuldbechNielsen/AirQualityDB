using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ASPNETCoreBSON.Model
{
    public class Ozone
    {
        [BsonId]
        public int Ozone_Id { get; set; }
        public DateTime DateTimeStart { get; set; }
        public double? Ozone1 { get; set; }
        public string Unit { get; set; }
    }
}
