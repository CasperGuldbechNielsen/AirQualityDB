using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ASPNETCoreBSON.Model
{
    public class Ozzone
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public DateTime DateTimeStart { get; set; }

        //Due to the data we got, this property in the xml is 'Ozone' which in C# is not allowed to be named 
        //as the class itself::: so the class is now called Ozzone with double ZZ :)
        
        public double? Ozone { get; set; }
        public string Unit { get; set; }
    }
}
