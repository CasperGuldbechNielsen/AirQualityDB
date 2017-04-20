using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreBSON.Model;
using ASPNETCoreBSON.Contexts;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ASPNETCoreBSON.Repository
{
    public class OzonesRepository: IOzonesRepository
    {
        private readonly OzonesContext _context = null;

        public OzonesRepository(IOptions<Settings> settings)
        {
            _context = new OzonesContext(settings);
        }

        public async Task Add(Ozzone ozzoneEntry)
        {
            try
            {
                await _context.Ozones.InsertOneAsync(ozzoneEntry);
            }
            catch (Exception e)
            {
                
                throw new Exception("Error during adding Ozzone using MongoDB\n" + e.Message);
            }
            
        }

        public async Task<IEnumerable<Ozzone>> GetAll()
        {
            try
            {
                return await _context.Ozones.Find(_ => true).ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error during getting Ozzone using MongoDB\n" + e.Message);
            }
           
        }

        public async Task<Ozzone> Find(string id)
        {
            var filter = Builders<Ozzone>.Filter.Eq("_id", id);
            try
            {
                return await _context.Ozones.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Error during finding Ozzone using MongoDB\n" +e.Message);
            }
            
        }

        public async Task<DeleteResult> Remove(string id)
        {
            try
            {
                return await _context.Ozones.DeleteOneAsync(Builders<Ozzone>.Filter.Eq("_id", id));
            }
            catch (Exception e)
            {
                throw new Exception("Error during removing Ozzone using MongoDB\n" + e.Message);
            }
            
        }

        public async Task<UpdateResult> Update(Ozzone ozzoneEntry)
        {
            //in reality this is the closest case study I would imagine:
            //filter by the time it was taken
            var filter = Builders<Ozzone>.Filter.Eq(x => x.DateTimeStart, ozzoneEntry.DateTimeStart);
            //update or correct measurements
            var update = Builders<Ozzone>.Update.Set(x => x.Ozone, ozzoneEntry.Ozone);

            try
            {
                return await _context.Ozones.UpdateOneAsync(filter, update);
            }
            catch (Exception e)
            {
                throw new Exception("Error during updating Ozzone using MongoDB\n" + e.Message);
            }

            
        }
    }
}
